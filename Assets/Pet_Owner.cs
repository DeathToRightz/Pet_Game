using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Pet_Owner : MonoBehaviour
{
    [SerializeField] Button enterButton;
    [SerializeField] TMP_InputField enterNameInput;
    [SerializeField] Slider hungerbar;
    Pet myPet;
   
    void Start()
    {
      
        enterButton.gameObject.SetActive(false);
        Debug.Log(hungerbar.value);
    }

    
    void Update()
    {
        if(enterNameInput.text != "")
        {
            enterButton.gameObject.SetActive(true);
            
        }
        if(Input.GetKeyUp(KeyCode.Space))
        {
            Debug.Log(myPet.Name);
        }
    }

    public void OnClickPetNameButton()
    {
        myPet = new Pet();
        myPet.Name = enterNameInput.text;
       
        
        
    }
}
