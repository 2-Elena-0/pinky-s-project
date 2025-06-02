using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateEnemyes : MonoBehaviour
{
    public GameObject NewEnemy;
    public float nextEnemy = 0f;
    public int createTime = 3;

    public Vector2 whereCreate = new Vector2((float)-10.5, (float)-2.23);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextEnemy)
        {
            nextEnemy = Time.time + createTime;
            Instantiate(NewEnemy, whereCreate, Quaternion.identity);
        }
    }
}
