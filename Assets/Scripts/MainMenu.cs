using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    //method that is used to start the game and put the player at the first level of the game
    public void StartGame()
    {
        FindObjectOfType<GameSession>().ResetGameSession();
        SceneManager.LoadScene(1);
    }
}
