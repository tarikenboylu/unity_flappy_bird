using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Duvar : MonoBehaviour
{
    public GameObject Wall;
    public GameObject Cloud;
    public GameObject[] Tree;
    float createTime = 1f;
    float createTime2 = 0.1f;
    float createTime3 = 0.1f;
    float sonGecenSure;
    float sonGecenSureTree;
    float sonGecenSureCloud;
    public float skor = 0;
    public Text skorBoard;
    public int treeRandom = 0;
    void Update()
    {
        skorBoard.text = "Skor = " + skor;
        treeRandom = Random.Range(0, Tree.Length);
        sonGecenSure = createTime - Time.time;
        sonGecenSureTree = createTime2 - Time.time;
        sonGecenSureCloud = createTime3 - Time.time;
        if (sonGecenSure < 0)
        {
            try
            {
                if (GetComponent<MoveCharacter>().move)
                {
                    if(transform.position.y < 4.5f && transform.position.y > -5.5f)
                    { 
                        GameObject InstanceWall = Instantiate(Wall, transform.position + new Vector3(15, Random.Range(-1.5f, 1.5f), 0), Quaternion.Euler(0, 0, 1));
                        InstanceWall.GetComponent<MoveWalls>().Character = gameObject;
                    }
                    if(transform.position.y < -5.5f)
                    { 
                        GameObject InstanceWall = Instantiate(Wall, transform.position + new Vector3(15, Random.Range(0f, 2f), 0), Quaternion.Euler(0, 0, 1));
                        InstanceWall.GetComponent<MoveWalls>().Character = gameObject;
                    }
                    if(transform.position.y >= 4.5f)
                    { 
                        GameObject InstanceWall = Instantiate(Wall, transform.position + new Vector3(15, Random.Range(-2f, 0), 0), Quaternion.Euler(0, 0, 1));
                        InstanceWall.GetComponent<MoveWalls>().Character = gameObject;
                    }
                }
            }
            catch
            {
                return;
            }
            createTime += Random.Range(0.7f, 1.3f);
        }

        if (sonGecenSureTree < 0)
        {
            try
            {
                if (GetComponent<MoveCharacter>().move)
                {
                    GameObject InstanceTree = Instantiate(Tree[treeRandom], new Vector3(15, Random.Range(-1f, 3f) - 6f, 8), Quaternion.Euler(0, 0, 0));
                    InstanceTree.transform.localScale = new Vector3(Random.Range(0.7f, 1.2f) * Random.Range(0.5f, 0.8f), Random.Range(0.7f, 1.2f), 1);
                    InstanceTree.GetComponent<MoveWalls>().Character = gameObject;
                }
            }
            catch
            {
                return;
            }
            createTime2 += Random.Range(0.33f, 1.00f);
        }

        if (sonGecenSureCloud < 0)
        {
            try
            {
                if (GetComponent<MoveCharacter>().move)
                {
                    GameObject InstanceCloud = Instantiate(Cloud, new Vector3(15, Random.Range(0f, 3f), 9), Quaternion.Euler(0, 0, 0));
                    InstanceCloud.transform.localScale = new Vector3(Random.Range(0.7f, 1.2f) * Random.Range(0.5f, 1f), Random.Range(0.7f, 1.2f), 1);
                    InstanceCloud.GetComponent<MoveWalls>().Character = gameObject;
                }
            }
            catch
            {
                return;
            }
            createTime3 += Random.Range(0.33f, 1.00f);
        }
    }
}
