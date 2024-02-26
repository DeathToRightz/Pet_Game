using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//////////////////////////////////////////////
//Assignment/Lab/Project: Virtual Pet Game
//Name: Logan Cordova
//Section: SGD.213.2172
//Instructor: Professor Sowers
//Date: 02/26/2024
/////////////////////////////////////////////
public class MenuController : MonoBehaviour
{
    //Starts game
    public void OnClickStartGame()
    {
        SceneManager.LoadScene(2);
    }
    //Restarts game
    public void OnClickRestartGame()
    {
        SceneManager.LoadScene(2);
    }
    //Quits out of game
    public void OnClickQuitGame()
    {
        Application.Quit();
    }
    //Moves back to Title screen
    public void OnClickBack()
    {
        SceneManager.LoadScene(0);
    }
    //Moves to Rules
    public void OnClickRules()
    {
        SceneManager.LoadScene(1);
    }
}
