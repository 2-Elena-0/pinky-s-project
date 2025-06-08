using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;


public class Enemy : MonoBehaviour
{
    private Rigidbody2D rb;
    public Vector2 moveVector;
    public int step = 0;
    public int stepS = 0;
    private string vay;
    private bool IfDestroy = false;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        vay = GetMap();
    }

    private string GetMap()
    {
        StreamReader sr = new StreamReader("./Assets/Scenes/level 1/map1");
        string line = sr.ReadLine();
        return line;
    }

    private void Move(int stepp)
    {
        switch (vay[stepp])
         {
             case 'r':
                 moveVector.x = Input.GetAxis("Horizontal") + 1;
                 moveVector.y = Input.GetAxis("Vertical");
                 break;
             case 'l':
                 moveVector.x = Input.GetAxis("Horizontal") - 1;
                 moveVector.y = Input.GetAxis("Vertical");
                 break;
             case 'u':
                 moveVector.x = Input.GetAxis("Horizontal");
                 moveVector.y = Input.GetAxis("Vertical") + 1;
                 break;
             case 'd':
                 moveVector.x = Input.GetAxis("Horizontal");
                 moveVector.y = Input.GetAxis("Vertical") - 1;
                 break;
         }
    }


    void FixedUpdate()
    {
        if (step < 50 * vay.Length)
        {
            if (step % 50 == 0)
            {
                Move(step / 50);
            }

            rb.MovePosition(rb.position + moveVector * 1f * Time.deltaTime);
            step += 1;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}