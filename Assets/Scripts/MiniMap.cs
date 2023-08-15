using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniMap : MonoBehaviour
{   
    public GameObject mainCamera;
    public GameObject miniMapCamera;
    //public GameObject mainInterfaceObject;

    bool isMenuOpen = false;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            if (!isMenuOpen)
            {
                miniMapCamera.SetActive(true);
                mainCamera.SetActive(false);
                //mainInterfaceObject.SetActive(false);
                isMenuOpen = true;
            } else
            {
                miniMapCamera.SetActive(false);
                mainCamera.SetActive(true);
                //mainInterfaceObject.SetActive(true);
                isMenuOpen = false;
            }

        }
    }
}