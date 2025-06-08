using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapScript : MonoBehaviour
{

    public bool IsTowerBuilding = false;
    public GameObject newTower;
    
    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && IsTowerBuilding)
        {
            Vector2 diference = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Instantiate(newTower, diference, Quaternion.identity);
            IsTowerBuilding = false;
        }
        
    }
}
