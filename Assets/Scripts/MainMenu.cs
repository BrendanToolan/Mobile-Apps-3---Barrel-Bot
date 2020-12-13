using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject optionsMenu;
    public bool isMainMenuOpened;
    public bool isOptionsMenuOpened;

    void Start()
    {
        mainMenu.SetActive(true);
        optionsMenu.SetActive(false);
    }

    //method that is used to start the game and put the player at the first level of the game
    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
        Debug.Log("Starting The Game");
    }

    public void Options()
    {
        mainMenu.SetActive(false);
        optionsMenu.SetActive(true);
        Time.timeScale = 0f;
        isOptionsMenuOpened = true;
        isMainMenuOpened = false;
        Debug.Log("button works");
    }

    //method used to quit the game
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Exiting the game");
    }
}
