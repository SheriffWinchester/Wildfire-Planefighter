using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterTank : C_PlaneController
{
    public int waterTank = 0;

    public float fireRate = 0.35f;
    float nextFire = 0f;
    public GameObject water;
    GameObject waterObject;
    void Update()
    {
        //Debug.Log("WATER TANK: " + waterTank);
        // if (waterTank < 10)
        // {
            FillTank();
        // }
        DropWater();
    }
    public void DropWater()
    {
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > nextFire && waterTank > 0)
        {
            nextFire = Time.time + fireRate;
            //Debug.Log("Shoot");
            if(Time.timeScale != 0f)
            {
                waterObject = Instantiate(water, transform.position, Quaternion.identity);
                waterTank -= tankCounter;
            }
        }
    }
    void FillTank()
    {
        if (waterStay)
        {
            if (waterTank < 10)
            {
                if (Input.GetKeyDown(KeyCode.C))
                {
                waterTank += tankCounter;
                }
            }
        }
        //Debug.Log(waterTank);
    }
}
