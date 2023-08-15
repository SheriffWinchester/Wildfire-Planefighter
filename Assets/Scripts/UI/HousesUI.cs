using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HousesUI : MonoBehaviour {

    public TextMeshProUGUI scoreHouse;

    //public GameObject objectWithScript;
    //ScoreController scoreController;
    HouseManager houseManager;
    GameObject controller;
    
    
    void Start() 
    {
        //scoreController = GameObject.FindWithTag("GameController").GetComponent<ScoreController>();
        scoreHouse = GetComponent<TextMeshProUGUI>();
        controller = GameObject.Find("Spawner Houses");
        houseManager = controller.GetComponent<HouseManager>();
    }

    void Update() 
    {

        scoreHouse.text = string.Format("{0}", houseManager.houseObjects.Count);

    }

}