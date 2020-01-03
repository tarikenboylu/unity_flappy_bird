using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LikeMove : MonoBehaviour
{
    public GameObject Character;
    public bool die = false;
    //public GameObject[] All;
    void Start()
    {
        die = false;
        //All = new GameObject [1000];
    }

    void Update()
    {
        if (/*Input.touchCount > 0*/Input.GetKeyDown(KeyCode.R) && die == true)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name, LoadSceneMode.Single);
            /*foreach (GameObject Obje in All)
            { 
                Destroy(Obje);
            }*/
        }
        try
        {
            if (Character.GetComponent<MoveCharacter>().move)
                GetComponent<MeshRenderer>().materials[0].SetTextureOffset("_MainTex", new Vector2(Time.time * 0.06f, 0));
        }
        catch
        {
            return;
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Character.GetComponent<Duvar>().skor += 0.5f ;
    }
}
