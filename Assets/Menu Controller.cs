using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void OnClickStartGame()
    {
        SceneManager.LoadScene(2);
    }
    public void OnClickRestartGame()
    {
        SceneManager.LoadScene(2);
    }
    public void OnClickQuitGame()
    {
        Application.Quit();
    }
    public void OnClickBack()
    {
        SceneManager.LoadScene(0);
    }
    public void OnClickRules()
    {
        SceneManager.LoadScene(1);
    }
}
