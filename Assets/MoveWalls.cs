using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWalls : MonoBehaviour
{
    public GameObject Character;
    public float outofScreen = -20;

    void Update()
    {
        try
        {
            if (Character.GetComponent<MoveCharacter>().move)
            {
                if (transform.position.x > -20)
                {
                if (Time.time > 10)
                    transform.position -= new Vector3(0.2f, 0, 0) * Time.time * 0.1f;
                else
                    transform.position -= new Vector3(0.2f, 0, 0);
                }

            }
            
        }
        catch
        {
            return;
        }

        if (transform.position.x < outofScreen)
            Destroy(gameObject);
    }
}
