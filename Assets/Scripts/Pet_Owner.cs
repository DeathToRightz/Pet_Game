using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
//////////////////////////////////////////////
//Assignment/Lab/Project: Virtual Pet Game
//Name: Logan Cordova
//Section: SGD.213.2172
//Instructor: Professor Sowers
//Date: 02/26/2024
/////////////////////////////////////////////

public class Pet_Owner : MonoBehaviour
{
    //The buttons used for interacting with the pet
    [Header ("Buttons")]
    [SerializeField] Button enterNameButton;
    [SerializeField] Button feedButton;
    [SerializeField] Button playButton;
    [SerializeField] Button restButton;

    //The sliders showing a visual for the hunger, energy, and bored bars
    [Header ("Sliders")]
    [SerializeField] Slider hungerBar;
    [SerializeField] Slider boredBar;
    [SerializeField] Slider energyBar;

    //The name for the pet
    [Header ("Pet name")]
    [SerializeField] TMP_InputField enterNameInput;
    [SerializeField] TMP_Text petName;
    Pet myPet;
   
    //a bool to keeps track if there is a Pet object
    bool petIsAlive;
    
    //a bool that keeps track if one of the sliders are bing lowered
    bool loweringStats = false;
    //sliders lower by 1 initially
    int lowerStatMultiplyer = 1;
    void Start()
    {  
        //Sets the buttons inactive at the start of the game
        enterNameButton.gameObject.SetActive(false);
        feedButton.gameObject.SetActive(false);
        playButton.gameObject.SetActive(false);
        restButton.gameObject.SetActive(false); 
    }

    
    void Update()
    {
        //If the input field for the name is present
        if (enterNameInput)
        {
            //If the player inputs something in the input field the enter button for the name will appear
            if (enterNameInput.text != "")
            {
               
                enterNameButton.gameObject.SetActive(true);

            }
        }

        // If a Pet object is created and it's stats are not being lowered 
        if (petIsAlive && !loweringStats)
        {
            //Depending on which number is selected it will lower that specific stat
            switch (Random.Range(0, 3))
            {
                case 0:
                    //If the random range rolls a 5 it will cause the stat to lower
                    if (Random.Range(0, 10) == 5)
                    {
                       //The hunger bar will lower equalling the Hunger method and its value changing by the lower stat Multiplyer
                        hungerBar.value = myPet.Hunger -= lowerStatMultiplyer;
                        //After every time a stat is lowered the value of the lower stat multyplyer will increase by 1 
                        lowerStatMultiplyer++;
                        //The lowering stats bool is true 
                        loweringStats = true;
                        //Starts the Buffer IEnumerator
                        StartCoroutine(Buffer());
                    }
                    break;

                case 1:
                    if (Random.Range(0, 10) == 5)
                    {
                        //The energy bar will lower equalling the Energy method and its value changing by the lower stat Multiplyer
                        energyBar.value = myPet.Energy -= lowerStatMultiplyer;
                        lowerStatMultiplyer++;
                        loweringStats = true;
                        StartCoroutine(Buffer());
                    }
                    break;

                case 2: 
                    if(Random.Range(0, 10) == 5)
                    {
                        //The bored bar will lower equalling the Boredom method and its value changing by the lower stat Multiplyer
                        boredBar.value = myPet.Bordeom -= lowerStatMultiplyer;
                        lowerStatMultiplyer++;
                        loweringStats = true;
                        StartCoroutine(Buffer());
                    }
                    break;
            }
            
            
           
        }
        //If there is a Pet object
        if (petIsAlive)
        {
            //If any of the stats is lower or equal to 0 its game over
            if (hungerBar.value <= 0 || boredBar.value <= 0 || energyBar.value <= 0)
            {
                SceneManager.LoadScene(3);
            }
        }
        
    }
    //When the enter button is clicked on screen
    public void OnClickPetNameButton()
    {
        //Creates a Pet object
        myPet = new Pet();
       
        //Sets the pet is alive bool true
        petIsAlive = true;
        
        //The name of the Pet object is the name in the input field
        myPet.Name = enterNameInput.text;
       
        //Displays the name of the pet on the screen
        petName.text = $"Pet name is: {enterNameInput.text}";
      
        //Sets the corresponding buttons true and false
        enterNameInput.gameObject.SetActive(false); //For some reason this doesn't make the enter button on the screen dissapear
        playButton.gameObject.SetActive(true);
        restButton.gameObject.SetActive(true);
        feedButton.gameObject.SetActive(true);    
    }
    //When feed button is clicked the Eat method from the Pet class will activate
    public void OnClickFeedButton()
    {
        hungerBar.value = myPet.Eat();   
        
    }
    //When Play button is clicked the Play method from the Pet class will activate
    public void OnClickPlayButton()
    {
        boredBar.value = myPet.Play();
       
    }
    //When Rest button is clicked the Rest method from the Pet class will activate
    public void OnClickRestButton() 
    {
        energyBar.value = myPet.Rest();
       
    }
    //Gives a 10 second cooldown between lowering stats
    IEnumerator Buffer()
    {
        
       yield return new WaitForSeconds(10);
       loweringStats = false;

    }
    

    
}
