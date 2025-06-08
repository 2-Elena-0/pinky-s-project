using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tower : MonoBehaviour
{
    private float LastHit = 0f;
    private float reload = 1f;
    private Vector2 CenterOfTower;
    public List<GameObject> enemies = new List<GameObject>();
    public List<GameObject> destroyed = new List<GameObject>();

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(other.gameObject);
        enemies.Add(other.gameObject);
    }

    private void Update()
    {
        if (enemies.Count != 0)
        {
            if (Time.time - LastHit > reload)
            {
                LastHit = Time.time;
                foreach (var enem in enemies)
                {
                    Enemy e = enem.GetComponent<Enemy>();
                    e.hp -= 1;
                    if (e.hp == 0)
                    {
                        e.kill();
                        destroyed.Add(enem);
                    }
                }

                if (destroyed.Count != 0)
                {
                    foreach (var i in destroyed)
                    {
                        enemies.Remove(i);
                    }
                    destroyed.Clear();
                }
            }
        }
    }
}