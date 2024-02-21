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
        /*else
        {
            StartCoroutine(EnterButtonOff());
        }*/
        
        
    }

    public void OnClickPetNameButton()
    {
        myPet = new Pet();
        myPet.Name = enterNameInput.text;
        enterNameInput.gameObject.SetActive(false);
        playButton.gameObject.SetActive(true);
        restButton.gameObject.SetActive(true);
        feedButton.gameObject.SetActive(true);
       

        
    }
    public void OnClickFeedButton()
    {   
        hungerBar.value += myPet.Eat();
    }
    public void OnClickPlayButton()
    {
        boredBar.value += myPet.Play();
    }
    public void OnClickRestButton() 
    {
        energyBar.value += myPet.Rest();
    }
}
