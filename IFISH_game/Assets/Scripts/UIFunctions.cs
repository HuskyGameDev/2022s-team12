using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIFunctions : MonoBehaviour
{
 
    public void startGame()
    {
        SceneManager.SetActiveScene(SceneManager.GetSceneByName("SampleScene") );
        SceneManager.UnloadSceneAsync("Main_Menu");
        Debug.Log("Game Started!");
    }

    public void exitGame()
    {
        Debug.Log("Game Closed!");
        Application.Quit();
    }

    public void returnToMenu()
    {
        SceneManager.LoadScene("Main_Menu", LoadSceneMode.Additive);
        SceneManager.UnloadSceneAsync("SampleScene");
        Debug.Log("Sent to main menu!");
    }

}