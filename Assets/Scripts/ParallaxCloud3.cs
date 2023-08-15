using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxCloud3 : MonoBehaviour
{
    //public float depth = 1;
    public float speed = 7;
    // Update is called once per frame
    void FixedUpdate()
    {
        // float realVelocity = player.velocity.x / depth;
        // Vector2 pos = transform.position;

        // pos.x -= realVelocity * Time.fixedDeltaTime;

        transform.position -= transform.right * speed * Time.deltaTime;
        Vector2 pos = transform.position;
        if (pos.x <= -25)
            pos.x = 20;
        transform.position = pos;
    }
}