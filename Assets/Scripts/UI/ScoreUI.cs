using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreUI : MonoBehaviour {

    public TextMeshProUGUI scoreText;

    public GameObject objectWithScript;
    //ScoreController scoreController;
    
    void Start() 
    {
        //scoreController = GameObject.FindWithTag("GameController").GetComponent<ScoreController>();
        scoreText = GetComponent<TextMeshProUGUI>();
    }

    void Update() 
    {
        scoreText.text = C_TreeScript.mainScore.ToString();
    }

}