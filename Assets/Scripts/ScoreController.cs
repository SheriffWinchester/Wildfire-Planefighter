using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class ScoreController : MonoBehaviour
{

    public GameObject winMenu;
    public GameObject scoreMenu;
    public GameObject mainInterface;
    public TextMeshProUGUI scoreWinText;
    public TextMeshProUGUI scoreText;

    public GameObject pauseMenu;
    public GameObject tutorialMenu;
    public GameObject tutorialMenu2;
    bool gameIsPaused = false;

    C_TreeScript c_TreeScript;
    HouseManager houseManager;
    TimerUI timerUI;
    GameObject houseObjectManager;

    GameObject timerUIObject;

    void Start() 
    {
        houseObjectManager = GameObject.Find("Spawner Houses");
        timerUIObject = GameObject.Find("Timer");
        scoreText = scoreMenu.transform.GetChild(1).gameObject.GetComponent<TextMeshProUGUI>();
        c_TreeScript = GetComponent<C_TreeScript>();
        houseManager = houseObjectManager.GetComponent<HouseManager>();
        timerUI = timerUIObject.GetComponent<TimerUI>();
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
        //if (timerUI.timeRemaining <= 0 || HouseManager.houseObjects.Count <= 0)
        if (timerUI.timeRemaining <= 0 || houseManager.houseObjects.Count <= 0)
        {
            Time.timeScale = 0;
            scoreMenu.SetActive(true);
            mainInterface.SetActive(false);
            scoreText.text = c_TreeScript.mainScore.ToString();
            
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
                if (tutorialMenu.activeInHierarchy == true || tutorialMenu2.activeInHierarchy == true)
                {
                    tutorialMenu.SetActive(false);
                }
                if (tutorialMenu2.activeInHierarchy == true)
                {
                    tutorialMenu2.SetActive(false);
                    mainInterface.SetActive(true);
                    
                }
            }
        //}
        
    }
}
