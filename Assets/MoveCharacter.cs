using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCharacter : MonoBehaviour
{
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }
    
    void Update()
    {
        //if(Input.GetKey(KeyCode.A))
            //rb.velocity = new Vector2(-2, rb.velocity.y);
        //if(Input.GetKey(KeyCode.D))
            rb.velocity = new Vector2(5, rb.velocity.y);
        if(Input.touchCount > 0)
            rb.velocity = new Vector2(rb.velocity.x, 5);

    }
}
