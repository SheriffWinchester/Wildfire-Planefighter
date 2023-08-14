using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneController : C_PlaneController
{
    public float movX;
    public float movY;
    public float acceleration;
    public float rotationControl;
    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        movY = Input.GetAxis("Horizontal"); 
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        MovePlane(movX, movY, acceleration, rotationControl, rb);
    }
    //Check whether the plane is or is not above the water tiles
    void OnTriggerStay2D(Collider2D collision) {
        if (collision.gameObject.name == "Tilemap_Water")
        {
            waterStay = true;
            //Debug.Log("WATER");
            
        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Tilemap_Water")
        {
            //Debug.Log("EXIT");
            waterStay = false;
        }
    }
}