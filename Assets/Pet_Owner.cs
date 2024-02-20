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
    [Header ("Everything else")]
    [SerializeField] TMP_InputField enterNameInput;
    Pet myPet;
   
    void Start()
    {

        enterNameButton.gameObject.SetActive(false);
        
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
            enterNameButton.gameObject.SetActive(false);
        }*/
        
        
    }

    public void OnClickPetNameButton()
    {
        myPet = new Pet();
        myPet.Name = enterNameInput.text;
        enterNameInput.gameObject.SetActive(false);
       
        
        //hungerbar.value = myPet.Hunger;
    }
    public void OnClickFeedButton()
    {
        hungerBar.value += myPet.Eat();
    }
}
