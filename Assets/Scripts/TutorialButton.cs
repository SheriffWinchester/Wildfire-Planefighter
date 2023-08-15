using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TutorialButton : MonoBehaviour {

    public GameObject pauseMenu;
    public GameObject tutorialMenu;

    public void TutorialLoad()
    {
        pauseMenu.SetActive(false);
        tutorialMenu.SetActive(true); 
    }

}