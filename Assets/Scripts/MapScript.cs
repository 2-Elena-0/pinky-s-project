using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapScript : MonoBehaviour
{

    public bool IsTowerBuilding = false;
    
    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && IsTowerBuilding)
        {
            Debug.Log("Update");
            IsTowerBuilding = false;
        }
        
    }
}
