using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HousesUI : MonoBehaviour {

    public TextMeshProUGUI scoreHouse;
    
    
    void Start() 
    {
        scoreHouse = GetComponent<TextMeshProUGUI>();
    }

    void Update() 
    {

        scoreHouse.text = string.Format("{0}", Singleton.instance.houseObjects.Count);

    }

}