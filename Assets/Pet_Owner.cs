using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Pet_Owner : MonoBehaviour
{
    [Header ("Buttons")]
    [SerializeField] Button enterNameButton;
    [SerializeField] Button feedButton;
    [SerializeField] Button playButton;
    [SerializeField] Button restButton;

    [Header ("Sliders")]
    [SerializeField] Slider hungerBar;
    [SerializeField] Slider boredBar;
    [SerializeField] Slider energyBar;

    [Header ("Everything else")]
    [SerializeField] TMP_InputField enterNameInput;
    Pet myPet;
    bool petIsAlive;
    bool loweringStats = false;
    void Start()
    {  
        enterNameButton.gameObject.SetActive(false);
        feedButton.gameObject.SetActive(false);
        playButton.gameObject.SetActive(false);
        restButton.gameObject.SetActive(false); 
    }

    
    void Update()
    {
        if (enterNameInput)
        {
            if (enterNameInput.text != "")
            {
               
                enterNameButton.gameObject.SetActive(true);

            }
        }

        if (petIsAlive && !loweringStats)
        {
            switch (Random.Range(0, 3))
            {
                case 0:
                    if (Random.Range(0, 10) == 5)
                    {
                        Debug.Log("lower");
                        hungerBar.value = myPet.Hunger -= 2;
                        loweringStats = true;
                    }
                    break;

                case 1:
                    if (Random.Range(0, 10) == 5)
                    {
                        Debug.Log("lower");
                        hungerBar.value = myPet.Hunger -= 2;
                        loweringStats = true;
                    }
                    break;

            }



            StartCoroutine(Buffer());
        }

    }

    public void OnClickPetNameButton()
    {
        myPet = new Pet();
        petIsAlive = true;
        myPet.Name = enterNameInput.text;
        enterNameInput.gameObject.SetActive(false);
        playButton.gameObject.SetActive(true);
        restButton.gameObject.SetActive(true);
        feedButton.gameObject.SetActive(true);    
    }
    public void OnClickFeedButton()
    {
        hungerBar.value = myPet.Eat();   
        
    }
    public void OnClickPlayButton()
    {
        boredBar.value = myPet.Play();
       
    }
    public void OnClickRestButton() 
    {
        energyBar.value = myPet.Rest();
       
    }

    IEnumerator Buffer()
    {
       yield return new WaitForSeconds(15);
        loweringStats = false;

    }
    
}
