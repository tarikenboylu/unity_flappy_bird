using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MoveCharacter : MonoBehaviour
{
    Rigidbody2D rb;
    public GameObject[] Crash;
    public GameObject BackGround;
    public GameObject Wall;
    public bool move = true;
    int crashRandom = 0;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    
    void Update()
    {
        crashRandom = Random.Range(0, 3);
        if(Input.touchCount > 0)
            rb.velocity = new Vector2(rb.velocity.x, 8);
        if(Input.GetKeyDown(KeyCode.W))
            rb.velocity = new Vector2(rb.velocity.x, 8);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        move = false;
        BackGround.GetComponent<LikeMove>().die = true;
        Destroy(gameObject);
        Instantiate(Crash[crashRandom], transform.position, new Quaternion(0, 0, 0, 0));
    }

}
