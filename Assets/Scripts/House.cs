using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class House : MonoBehaviour
{
    public int health = 100;

    void Update()
    {
        Debug.Log("House: " + health);
    }
}
