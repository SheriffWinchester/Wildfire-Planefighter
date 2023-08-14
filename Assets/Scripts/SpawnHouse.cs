using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnHouse : MonoBehaviour
{
    [SerializeField] List<Transform> houses = new List<Transform>();
    int randomHouse;
    public GameObject houseObject;
    // Start is called before the first frame update
    void Start()
    {
        foreach (Transform g in transform.GetComponentsInChildren<Transform>())
        {
            houses.Add(g); // Add each Transform to the List
        }
        randomHouse = Random.Range(1, houses.Count);
        Instantiate(houseObject, houses[randomHouse].position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
