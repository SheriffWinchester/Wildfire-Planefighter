using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterScript : MonoBehaviour
{   
    //public float _currentScale = InitScale;
    private float TimeScale = 1f;
    //public const float TargetScale = 0.5f;
    //public const float InitScale = 1f;

    Vector3 InitScale = new Vector3(1f, 1f, 1f);
    Vector3 TargetScale = new Vector3(0.5f, 0.5f, 0.5f);


    public const int FramesCount = 500;
    //float _dx = (InitScale - TargetScale)/FramesCount;

    public float deceleration = 1.5f;

    BoxCollider2D boxCollider;

    GameObject plane;
    Rigidbody2D rb_plane;
    Rigidbody2D rb;

    C_TreeScript c_TreeScript;
    GameObject controller;

    void Start()
    {
        controller = GameObject.Find("ScoreController");

        rb = GetComponent<Rigidbody2D>();
        rb_plane = GameObject.Find("Fireplane").GetComponent<Rigidbody2D>();
        rb.velocity = rb_plane.velocity;

        boxCollider = GetComponent<BoxCollider2D>();
        StartCoroutine(destroyObject());
        StartCoroutine(LerpUp());
        c_TreeScript = controller.GetComponent<C_TreeScript>();
    }


    void Update()
    {
        //ReduceScale();
        ReduceSpeed();

        // Debug.Log("Plane: " + rb_plane.velocity);
        // Debug.Log("Water: " + rb.velocity);
  
    }
    IEnumerator destroyObject()
    {
        yield return new WaitForSeconds(3f);
        //while(true)
        //{
            Destroy(gameObject);
        //}
        
    }
    IEnumerator LerpUp(){
        float progress = 0;
        
        while(progress <= 1){
            transform.localScale = Vector3.Lerp(InitScale, TargetScale, progress);
            progress += Time.deltaTime * TimeScale;
            yield return null;
        }
        boxCollider.enabled = true;
        transform.localScale = TargetScale;
	
    }
    // void ReduceScale()//Reduce scale of the water in free falling
    // {
    //     _currentScale -= _dx;
    //     if (_currentScale < TargetScale)
    //     {
    //         _currentScale = TargetScale;
    //         boxCollider.enabled = true;
    //         //Destroy(gameObject);
    //     }
    //     gameObject.transform.localScale = Vector3.one * _currentScale;
    // }
    void ReduceSpeed()//Reduce speed of the water in free falling
    {
        // Calculate the deceleration factor based on time
        float decelerationFactor = deceleration * Time.deltaTime;

        // Reduce the object's velocity by applying deceleration
        rb.velocity -= rb.velocity * decelerationFactor;

        // Clamp the velocity to ensure it doesn't become negative or too small
        //rb.velocity = Vector3.Max(rb.velocity, Vector3.zero);
    }
    void OnTriggerEnter2D(Collider2D collision)//Check tree's layer and extinguish
    {
        Debug.Log("Water HIT");
        if (collision.gameObject.layer == 7)//7 - "FireTree"
        {
            //Debug.Log(collision.gameObject.name);
            c_TreeScript.TreeExtinguish(collision);
            //Destroy(gameObject);

            Debug.Log("EXTINGUISH");
        }
    }
}
