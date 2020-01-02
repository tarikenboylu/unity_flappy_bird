using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Duvar : MonoBehaviour
{
    public GameObject Wall;
    float createTime = 5;
    float Songecensure;
    void Start()
    {
        
    }

    void Update()
    {
        Songecensure = createTime - Time.time;
        if (Songecensure < 0)
        {
            createTime += Random.Range(2, 5);
            Instantiate(Wall, transform.position + new Vector3(0, Random.Range(-8, 8), 0), Quaternion.Euler(0, 0, 0));
        }
    }
}
