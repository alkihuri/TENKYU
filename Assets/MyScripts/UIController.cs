using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
    public Text scoreUI, levelUI;
     
    // Update is called once per frame
    void Update()
    {
        scoreUI.text = "Score : " + GameStates.score.ToString();
        levelUI.text = "level : " + GameStates.level.ToString();
    }
}
