using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeScript : MonoBehaviour
{
    float raycastLength = 0.5f;
    int layerFireTree = 7;
    bool hitState = false;
    float time_;
    float hitTime;
    float delayTime = 5f;
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

    void Start()
    {
        StartCoroutine(Fire());
    }

    private void Update()
    {
        time_ = Time.time;
    }
    IEnumerator Fire()
    {
        while (true)
        {
            float coroutineTime = Random.Range(5f, 15f);

            if (gameObject.layer == layerFireTree)
            {
                Debug.Log("1");
                //StartCoroutine(DelayedAction());
                Debug.Log("5");
                float randomNumber = Random.Range(1f, 100f);
                foreach (Vector2 direction in directions)
                {
                    RaycastHit2D hit = Physics2D.Raycast(transform.position, direction, distance: 1);
                    Debug.DrawRay(transform.position, direction, color: Color.red, duration: 2);
                    if (hit.collider != null && hit.collider.gameObject.layer == 6)
                    {
                        Debug.Log("Hit, " + hit.collider.tag);
                        if (randomNumber > 50f)
                        {
                            hit.collider.GetComponent<SpriteRenderer>().color = Color.blue;
                            hit.collider.gameObject.layer = 7;
                            break;
                        }
                    }
                }
            }
            yield return new WaitForSeconds(coroutineTime);
        }
    }

    IEnumerator DelayedAction()
    {
        yield return new WaitForSeconds(5);

        Debug.Log("Start"); // Perform the delayed action here
    }
}
    






