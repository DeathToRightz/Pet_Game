using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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
    [SerializeField] TMP_Text petName;
    Pet myPet;
    bool petIsAlive;
    bool loweringStats = false;
    int lowerStatMultiplyer = 1;
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
                       
                        hungerBar.value = myPet.Hunger -= lowerStatMultiplyer;
                        lowerStatMultiplyer++;
                        loweringStats = true;
                        StartCoroutine(Buffer());
                    }
                    break;

                case 1:
                    if (Random.Range(0, 10) == 5)
                    {
                       
                        energyBar.value = myPet.Energy -= lowerStatMultiplyer;
                        lowerStatMultiplyer++;
                        loweringStats = true;
                        StartCoroutine(Buffer());
                    }
                    break;

                case 2: 
                    if(Random.Range(0, 10) == 5)
                    {
                       
                        boredBar.value = myPet.Bordeom -= lowerStatMultiplyer;
                        lowerStatMultiplyer++;
                        loweringStats = true;
                        StartCoroutine(Buffer());
                    }
                    break;
            }
            
            
           
        }

        if (petIsAlive)
        {
            if (hungerBar.value == 0 || boredBar.value == 0 || energyBar.value == 0)
            {
                SceneManager.LoadScene(3);
            }
        }
        
    }

    public void OnClickPetNameButton()
    {
        myPet = new Pet();
        petIsAlive = true;
        myPet.Name = enterNameInput.text;
        petName.text = $"Pet name is: {enterNameInput.text}";
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
        
       yield return new WaitForSeconds(10);
       loweringStats = false;

    }
    IEnumerator MultiplyNegative( int statLower)
    {
        
        yield return new WaitForSeconds(8);
        statLower += 2;

    }

    
}
