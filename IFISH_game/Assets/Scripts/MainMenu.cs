using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
 
    public void startGame()
    {
        Debug.Log("Game Started!");
        SceneManager.LoadScene("SampleScene");
    }

    public void exitGame()
    {
        Debug.Log("Game Closed!");
        Application.Quit();
    }

}