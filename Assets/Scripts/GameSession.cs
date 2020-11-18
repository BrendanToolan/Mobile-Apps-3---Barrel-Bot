using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameSession : MonoBehaviour
{
    private void Awake()
   {
       int numGameSession = FindObjectsOfType<GameSession>().Length;
       if(numGameSession > 1)
       {
           Destroy(gameObject);
        
       }
       else
       {
           DontDestroyOnLoad(gameObject);
       }
   }

   public void ResetGameSession()
   {
       SceneManager.LoadScene(0);
       Destroy(gameObject);
      
   }
}
