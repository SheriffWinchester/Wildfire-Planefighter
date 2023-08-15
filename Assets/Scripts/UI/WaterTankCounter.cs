using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class WaterTankCounter : MonoBehaviour {

    public TextMeshProUGUI waterTankText;

    public GameObject objectWithScript;
    //ScoreController scoreController;
    
    void Start() 
    {
        //scoreController = GameObject.FindWithTag("GameController").GetComponent<ScoreController>();
        waterTankText = GetComponent<TextMeshProUGUI>();
    }

    void Update() 
    {
        waterTankText.text = C_PlaneController.waterTank.ToString();
    }

}