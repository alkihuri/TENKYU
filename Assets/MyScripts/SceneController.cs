using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    private void Start()
    {
       
    }
    public void ChangeScene(string name)
    {
        if(name == "Start" || name == "Game")
        {
            GameStates.score = 0;
            GameStates.level = 1;
        }
            
        
        SceneManager.LoadScene(name);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
