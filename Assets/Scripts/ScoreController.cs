using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class ScoreController : MonoBehaviour
{

    public GameObject winMenu;
    public GameObject scoreMenu;
    public TextMeshProUGUI scoreWinText;
    public TextMeshProUGUI scoreText;

    public GameObject pauseMenu;
    public GameObject tutorialMenu;
    bool gameIsPaused = false;

    void Start() 
    {
        scoreText = scoreMenu.transform.GetChild(1).gameObject.GetComponent<TextMeshProUGUI>();
    }

    void Update() 
    {
        if(gameIsPaused == false)
        {
            Time.timeScale = 1;
        }
        // if (score >= 1000)
        // {   
        //     Time.timeScale = 0;
        //     winMenu.SetActive(true);
        //     scoreWinText.text = "Score " + score;

        // }
        //if (TimerUI.timeRemaining <= 0 || HouseManager.houseObjects.Count <= 0)
        if (HouseManager.houseObjects.Count <= 0)
        {
            Time.timeScale = 0;
            scoreMenu.SetActive(true);
            scoreText.text = C_TreeScript.mainScore.ToString();
            
        }
        // if(tutorialMenu.activeInHierarchy != true)
        // {
            if(Input.GetKeyDown(KeyCode.Escape))
            {
                if (gameIsPaused)
                {
                    Time.timeScale = 1f;
                    pauseMenu.SetActive(false);
                    gameIsPaused = false;
                } else
                {
                    Time.timeScale = 0f;
                    pauseMenu.SetActive(true);
                    gameIsPaused = true;
                }
                // if (tutorialMenu.activeInHierarchy == true)
                // {
                //     tutorialMenu.SetActive(false);
                // }
            }
        //}
        
    }
}
