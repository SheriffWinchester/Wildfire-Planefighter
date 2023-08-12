using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneMovement : MonoBehaviour
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
        
        Vector2 Vel = -transform.right * (movX * acceleration);
        rb.AddForce(Vel);
        rb.rotation += -movY * rotationControl;
        rb.velocity = Vector3.ClampMagnitude(rb.velocity, 2);
    }
}