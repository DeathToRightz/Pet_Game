using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Pet_Owner : MonoBehaviour
{
    [SerializeField] TMP_InputField enterName;
    Pet myPet;
   
    void Start()
    {
        myPet = new Pet();


        /*if (myPet.Name == "")
        {
            Debug.Log("I dont have a name.");

        }
        else
        {
            Debug.Log($"My name is {myPet.Name}");
        }
        if (myPet.Bordeom == 0)
        {
            Debug.Log("Im dying of boredom");
        }
        else
        {
            Debug.Log($"Im this much not bored: {myPet.Bordeom}");
        }*/
    }

    
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Debug.Log(myPet.Name);
        }
    }

    public void OnClickPetNameButton(TMP_InputField name)
    {

        myPet.Name = name.ToString();
        
    }
}
