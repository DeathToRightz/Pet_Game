using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pet_Owner : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Pet myPet;
        myPet = new Pet();
       
        // myPet.Name = "Simba";
        //Debug.Log(myPet.Name);
        if(myPet.Name == "")
        {
            Debug.Log("I got no name!");
        }
        else
        {
            Debug.Log($"My new name is {myPet.Name}");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
