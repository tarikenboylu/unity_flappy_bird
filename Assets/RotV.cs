using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotV : MonoBehaviour
{
    void Update()
    {
        transform.eulerAngles = new Vector3(0, 0, (Mathf.Atan(GetComponentInParent<Rigidbody2D>().velocity.y / 7)) * 180 / Mathf.PI);

    }
}
