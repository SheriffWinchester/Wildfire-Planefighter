using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreUI : MonoBehaviour {

    public TextMeshProUGUI scoreText;

    public GameObject objectWithScript;
    //ScoreController scoreController;
    GameObject controller;
    C_TreeScript c_TreeScript;
    void Start() 
    {
        //scoreController = GameObject.FindWithTag("GameController").GetComponent<ScoreController>();
        scoreText = GetComponent<TextMeshProUGUI>();
        // controller = GameObject.Find("ScoreController");
        // c_TreeScript = controller.GetComponent<C_TreeScript>();
    }

    void Update() 
    {
        scoreText.text = Singleton.instance.mainScore.ToString();
    }

}