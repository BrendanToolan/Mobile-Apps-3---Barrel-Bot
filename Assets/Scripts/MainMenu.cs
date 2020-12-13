using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    //method that is used to start the game and put the player at the first level of the game
    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
        Debug.Log("Starting The Game");
    }

    public void Options()
    {
        Debug.Log("button works");
    }

    //method used to quit the game
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Exiting the game");
    }
}
