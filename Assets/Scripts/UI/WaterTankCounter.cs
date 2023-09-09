using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class WaterTankCounter : MonoBehaviour {

    public TextMeshProUGUI waterTankText;

    public GameObject objectWithScript;
    //ScoreController scoreController;
    WaterTank waterTankComp;
    GameObject controller;
    void Start() 
    {
        //scoreController = GameObject.FindWithTag("GameController").GetComponent<ScoreController>();
        waterTankText = GetComponent<TextMeshProUGUI>();
        // controller = GameObject.Find("Fireplane");
        // waterTankComp = controller.GetComponent<WaterTank>();
    }

    void Update() 
    {
        waterTankText.text = Singleton.instance.waterTank.ToString();
    }

}