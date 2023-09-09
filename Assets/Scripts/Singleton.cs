using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton : MonoBehaviour
{
    public static Singleton instance; //{ get; private set; }
    public int mainScore = 0;
    public int waterTank = 0;
    public float timeRemaining = 180;
    public List<GameObject> houseObjects = new List<GameObject>();
    private void Awake() 
    { 
        // If there is an instance, and it's not me, delete myself.
        
        if (instance != null && instance != this) 
        { 
            Destroy(this); 
        } 
        else 
        { 
            instance = this; 
        } 
    }
}
