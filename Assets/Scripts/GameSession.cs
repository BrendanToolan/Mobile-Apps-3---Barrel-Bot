using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameSession : MonoBehaviour
{
    [SerializeField] int playerLives = 5;
    [SerializeField] Text livesText = null;


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

   public void Start()
   {
       livesText.text = playerLives.ToString();
   }

   public void ProcessPlayerDeath(){
       if(playerLives > 1)
       {
           TakeLife();
       }
       else
       {
           ResetGameSession();
       }
   }

   private void TakeLife()
   {
       playerLives -= 1;
       var currScene = SceneManager.GetActiveScene().buildIndex;
       SceneManager.LoadScene(currScene);
       livesText.text = playerLives.ToString();
   }

   public void ResetGameSession()
   {
       SceneManager.LoadScene(4);
       Destroy(gameObject);
      
   }
}
