using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenePersists : MonoBehaviour
{

    private int startUp = 0;

    private void Awake(){
        int numOfScenesPersists = FindObjectsOfType<ScenePersists>().Length;

        if(numOfScenesPersists > 1)
        {
            Destroy(gameObject);
        }
        else{
            DontDestroyOnLoad(gameObject);
        }

    }

    private void Start(){
        startUp = SceneManager.GetActiveScene().buildIndex;
    }

    private void Update()
    {
        int currentScene = SceneManager.GetActiveScene().buildIndex;

        if(currentScene != startUp){
            Destroy(gameObject);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

    }
    
}
