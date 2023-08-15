using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounds : MonoBehaviour
{
    float xPos;
    float yPos;
    void OnTriggerExit2D(Collider2D collider) {
        if (collider.CompareTag("Plane"))
        {
            InversePosition(collider);
        }
    }
    public void InversePosition(Collider2D collider)
    {
        Debug.Log("Triggered: " + collider.transform.name);
        //Vector2 planePosition = collider.transform.position;
        Vector3 colliderAngles = collider.transform.eulerAngles;
        Vector3 newRotation = new Vector3(colliderAngles.x, colliderAngles.y, 
                                            (colliderAngles.z - 180));
        collider.transform.eulerAngles = newRotation;
    }
}
