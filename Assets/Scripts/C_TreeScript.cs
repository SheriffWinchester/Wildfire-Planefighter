using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_TreeScript : MonoBehaviour
{
    //public bool isBurning;
    Color burnColor = new Color(0.5f, 0.5f, 0.5f);
    //public int mainScore = 0;
    public void TreeBurn(Collider2D collider, GameObject fireObject, Vector3 transform)
    {
        collider.GetComponent<SpriteRenderer>().color = burnColor;
        collider.gameObject.layer = 7;
        //Instantiate(fireObject, transform, Quaternion.identity);
    }
    public void TreeExtinguish(Collider2D collision)
    {
        collision.GetComponent<SpriteRenderer>().color = Color.white;
        collision.gameObject.layer = 6;
        Singleton.instance.mainScore += 1;
    }
}