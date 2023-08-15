using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class House : MonoBehaviour
{
    public int health = 100;
    SpriteRenderer spriteRenderer;
    Vector3 fireOffset = new Vector3(0, 0.5f, 0);
    public GameObject fireObject;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        if (health <= 50)
        {
            spriteRenderer.color = Color.grey;
            //Instantiate(fireObject, (transform.position + fireOffset), Quaternion.identity);
        }
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
