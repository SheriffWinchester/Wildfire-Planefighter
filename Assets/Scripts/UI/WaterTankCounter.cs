using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class WaterTankCounter : MonoBehaviour {

    public TextMeshProUGUI waterTankText;

    public GameObject objectWithScript;
    void Start() 
    {
        waterTankText = GetComponent<TextMeshProUGUI>();
    }

    void Update() 
    {
        waterTankText.text = Singleton.instance.waterTank.ToString();
    }

}