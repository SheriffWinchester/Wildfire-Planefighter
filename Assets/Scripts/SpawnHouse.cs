using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnHouse : MonoBehaviour
{
    [SerializeField] List<Transform> houses = new List<Transform>();
    int randomSpawn;
    public GameObject houseObject;
    GameObject spawnedHouse;
    // Start is called before the first frame update
    void Start()
    {
        foreach (Transform g in transform.GetComponentsInChildren<Transform>())
        {
            houses.Add(g); // Add each Transform to the List
        }
        for (int i = 0; i < 3; i++)
        {
            randomSpawn = Random.Range(1, houses.Count);
            spawnedHouse = Instantiate(houseObject, houses[randomSpawn].position, Quaternion.identity);
            spawnedHouse.name = "House " + (i + 1);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
