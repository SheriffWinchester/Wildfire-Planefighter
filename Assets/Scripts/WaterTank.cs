using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterTank : MonoBehaviour
{
    float waterTank = 0f;
    void OnTriggerStay2D(Collider2D collision) {
        if (collision.gameObject.name == "Tilemap_Water")
        {
            Debug.Log("WATER");
            if (Input.GetKeyDown(KeyCode.Space))
            {
                waterTank = waterTank + 10f;
            }
        }
    }
    void Update()
    {
        Debug.Log(waterTank);
    }
}
