using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameOverScript : MonoBehaviour
{
    public void RetryGame(){
        SceneManager.LoadScene(1);
    }

    public void ReturnToMenu(){
        SceneManager.LoadScene(0);
    }

    public void QuitGame(){
        Application.Quit();
        Debug.Log("Quitting the Game");
    }
}
