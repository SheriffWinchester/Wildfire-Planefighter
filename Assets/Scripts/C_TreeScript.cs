using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_TreeScript : MonoBehaviour
{
    //public bool isBurning;
    public void TreeBurn(Collider2D collider, GameObject fireObject, Vector3 transform)
    {
        collider.GetComponent<SpriteRenderer>().color = Color.blue;
        collider.gameObject.layer = 7;
        //Instantiate(fireObject, transform, Quaternion.identity);
    }
    public static void TreeExtinguish(Collider2D collision)
    {
        collision.GetComponent<SpriteRenderer>().color = Color.white;
        collision.gameObject.layer = 6;
    }
}