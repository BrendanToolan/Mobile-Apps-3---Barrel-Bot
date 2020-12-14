/*
references

https://www.youtube.com/watch?v=YOaYQrN1oYQ&t=25s
https://www.youtube.com/watch?v=-Vp13LMjWsE

https://gamedevbeginner.com/the-right-way-to-make-a-volume-slider-in-unity-using-logarithmic-conversion/
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Audio;

public class MainMenu : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject optionsMenu;
    public bool isMainMenuOpened;
    public bool isOptionsMenuOpened;

    public AudioMixer audioMx;
    public Slider slider;


    void Start()
    {
        slider.value = PlayerPrefs.GetFloat("Volume", 0.75f);

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
        //Time.timeScale = 0f;
        isOptionsMenuOpened = true;
        isMainMenuOpened = false;
        Debug.Log("button works");
    }

    public void SetVolume(float vol){
        Debug.Log(vol);
        audioMx.SetFloat("vol", vol);
        PlayerPrefs.SetFloat("Volume", vol);
    }

    public void BackToMain()
    {
        mainMenu.SetActive(true);
        optionsMenu.SetActive(false);
        //Time.timeScale = 0f;
        isOptionsMenuOpened = false;
        isMainMenuOpened = true;
        Debug.Log("Works");
    }

    //method used to quit the game
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Exiting the game");
    }
}
