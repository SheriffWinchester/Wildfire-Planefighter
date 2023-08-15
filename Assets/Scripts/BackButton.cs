using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BackButton : MonoBehaviour {

    public GameObject pauseMenu;
    public GameObject tutorialMenu;
    public GameObject tutorialPage2;
    public GameObject mainInterface;

    public void BackLoad()
    {
        pauseMenu.SetActive(true);
        tutorialMenu.SetActive(false); 
    }
    public void NextPage()
    {
        tutorialMenu.SetActive(false);
        tutorialPage2.SetActive(true);
        mainInterface.SetActive(false);
    }
    public void BackLoad2()
    {
        tutorialMenu.SetActive(true);
        tutorialPage2.SetActive(false);
        mainInterface.SetActive(true);
    }

}