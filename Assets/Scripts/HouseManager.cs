using UnityEngine;
using System.Collections.Generic;

public class HouseManager : MonoBehaviour
{
    public static List<GameObject> houseObjects = new List<GameObject>();
    bool foundObjects = true;

    void Start()
    {
        
        for (int i = 0; i < houseObjects.Count; i++)
        {
            Debug.Log(houseObjects[i].name);
        }
    }

   

    void Update()
    {
        FindAndStoreHouseObjects();
        CheckHouseObjectsExistence();
        //Debug.Log(houseObjects.Count);
    }

    void CheckHouseObjectsExistence()
    {
        if (houseObjects.Count > 0)
        {
            foreach (GameObject house in houseObjects)
            {
                if (house == null)
                {
                    houseObjects.Remove(house);
                    //Debug.Log("A house is missing from the scene!");
                    
                }
                //Debug.Log(houseObjects.Count);
            }
        }

    }
     void FindAndStoreHouseObjects()
    {
        GameObject[] foundHouses = GameObject.FindGameObjectsWithTag("House");
        if (foundObjects)
        {
            foreach (GameObject house in foundHouses)
            {
                houseObjects.Add(house);
            }
            foundObjects = false;
        }
        
    }
}