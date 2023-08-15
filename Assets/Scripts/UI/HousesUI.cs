using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HousesUI : MonoBehaviour {

    public TextMeshProUGUI scoreHouse;

    public GameObject objectWithScript;
    //ScoreController scoreController;
    
    void Start() 
    {
        //scoreController = GameObject.FindWithTag("GameController").GetComponent<ScoreController>();
        scoreHouse = GetComponent<TextMeshProUGUI>();
    }

    void Update() 
    {
        if (HouseManager.houseObjects != null)
        {
            scoreHouse.text = HouseManager.houseObjects.Count.ToString();
        }
    }

}