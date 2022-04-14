using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIFunctions : MonoBehaviour
{ 
    public void startGame()
    {
        SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
        SceneManager.SetActiveScene(SceneManager.GetSceneByPath("Assets/Scenes/SampleScene.unity") );
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
        SceneManager.SetActiveScene(SceneManager.GetSceneByName("Main_Menu"));
        SceneManager.UnloadSceneAsync("SampleScene");
        Debug.Log("Sent to main menu!");
    }
}