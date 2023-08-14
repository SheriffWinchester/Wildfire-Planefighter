using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeScript : C_TreeScript
{
    public bool isBurning = false;

    public GameObject fireObject;

    private Vector2[] directions = {
        Vector2.up,
        new Vector2(1, 1).normalized, // Diagonal: up-right
        Vector2.right,
        new Vector2(1, -1).normalized, // Diagonal: down-right
        Vector2.down,
        new Vector2(-1, -1).normalized, // Diagonal: down-left
        Vector2.left,
        new Vector2(-1, 1).normalized
    };

    Vector3 fireOffset = new Vector3(0, 0.3f, 0);

    void Start()
    {
        if (gameObject.layer == 7)
        {
            Instantiate(fireObject, (transform.position + fireOffset), Quaternion.identity);
        }
        StartCoroutine(Burn());
    }
    void Update()
    {
        // if(gameObject.layer == 7)
        // {
        //     isBurning = true;
        // }
        // if(isBurning)
        // {
            
        // }
    }

    IEnumerator Burn()
    {
        while (true)
        {
            float coroutineTime = Random.Range(5f, 15f);

            if (gameObject.layer == 7) // 7 - "FireTree" layer
            {
                Debug.Log("1");
                //StartCoroutine(DelayedAction());
                Debug.Log("5");
                float randomNumber = Random.Range(1f, 100f);
                //Raycast in 8 directions
                foreach (Vector2 direction in directions)
                {
                    RaycastHit2D hit = Physics2D.Raycast(transform.position, direction, distance: 1);
                    Debug.DrawRay(transform.position, direction, color: Color.red, duration: 2);
                    if (hit.collider != null && hit.collider.gameObject.layer == 9)
                    {
                        Debug.Log("Hit house: " + hit.collider.tag);
                        if (randomNumber > 50f)//Chance of burning the tree, if the raycast hit succesfully - exit the foreach loop
                        {
                            hit.collider.GetComponent<House>().health -= 10;
                            break;
                        }
                    }
                    if (hit.collider != null && hit.collider.gameObject.layer == 6) // 6 - "Tree" layer
                    {
                        Debug.Log("Hit, " + hit.collider.tag);
                        if (randomNumber > 50f)//Chance of burning the tree, if the raycast hit succesfully - exit the foreach loop
                        {
                            TreeBurn(hit.collider, fireObject, transform.position);
                            Instantiate(fireObject, (hit.collider.transform.position + fireOffset), Quaternion.identity);
                            
                            if(hit.collider.gameObject.layer == 9)//9 - House layer
                            {
                                hit.collider.GetComponent<House>().health -= 10;
                            }
                            //isBurning = true;
                            Debug.Log(isBurning);
                            break;
                        }
                    }
                }
            }
            yield return new WaitForSeconds(coroutineTime);
        }
    }

    // IEnumerator DelayedAction()
    // {
    //     yield return new WaitForSeconds(5);

    //     Debug.Log("Start"); // Perform the delayed action here
    // }

    
}
    






