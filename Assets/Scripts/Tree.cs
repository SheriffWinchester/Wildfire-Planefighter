using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree : MonoBehaviour
{
    float raycastLength = 0.5f;
    int layerMask = 6;

    

    private Vector2[] directions = {
    Vector2.up,
    Vector2.up + Vector2.right,
    Vector2.right,
    Vector2.right + Vector2.down,
    Vector2.down,
    Vector2.down + Vector2.left,
    Vector2.left,
    Vector2.left + Vector2.up
    };

    void Start()
    {
        StartCoroutine(Fire());
    }

    private void Update()
    {
        // Loop through each direction and send raycast
        
    }
    IEnumerator Fire()
    {
        Debug.Log("Start");
        while(true)
        {
            
                float coroutineTime = Random.Range(3f, 6f);
                float randomNumber = Random.Range(1f, 30f);
                foreach (Vector2 direction in directions)
                {
                    RaycastHit2D hit = Physics2D.Raycast(transform.position, direction, distance: 1);

                    if (hit.collider.tag == "Tree")
                    {
                        // Raycast hit something, do something with the information
                        //Debug.DrawLine(transform.position, hit.point, Color.red);
                        Debug.Log("Hit");
                        if (randomNumber > 15f)
                        {
                            hit.collider.GetComponent<SpriteRenderer>().color = Color.blue;
                            hit.collider.tag = "FireTree";
                        }
                        
                    }
                    else
                    {
                        // Raycast didn't hit anything, do something else
                        Debug.DrawRay(transform.position, direction * raycastLength, Color.green);
                    }
                }
                yield return new WaitForSeconds(3);
            
        }
    }
}


