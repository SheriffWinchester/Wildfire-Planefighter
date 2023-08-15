using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_PlaneController : MonoBehaviour
{
    //Plane's water tank counter
    //public int waterTank = 0;
    public static bool waterStay = false;
    public int tankCounter = 1;
    public void MovePlane(float movX, float movY, float acceleration, float rotationControl, Rigidbody2D rb)
    {
        Vector2 Vel = transform.up * (movX * acceleration);
        rb.AddForce(Vel);
        rb.rotation += -movY * rotationControl;
        rb.velocity = Vector3.ClampMagnitude(rb.velocity, 2);
    }


}