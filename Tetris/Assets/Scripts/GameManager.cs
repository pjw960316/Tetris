using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject j_block;
    public Transform spawn_point;
    public int speed;
    
    int cnt = 0;
    // Start is called before the first frame update
    void Start()
    {
        Spawn();
    }

    // Update is called once per frame
    void Update()
    {
        cnt++;
        if(cnt%600 == 0)
        {
            Spawn();
        }
    }

    void Spawn()
    {
        Rigidbody2D rigid = GetComponent<Rigidbody2D>();
        Instantiate(j_block, spawn_point.position, spawn_point.rotation);
        //rigid.velocity = new Vector2(-1, -0.1f);
    }
}
