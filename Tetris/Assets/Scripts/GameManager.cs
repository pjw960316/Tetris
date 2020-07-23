using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    public GameObject[] blocks;
    public Transform[] spawn_point;
    //테트리스 게임의 난이도를 결정합니다.
    public float speed;

    GameObject block;
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
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (block.transform.position.x <= -4.5f)
            {
                return;
            }
            Debug.Log("<-");
            Vector2 cur = block.transform.position;
            block.transform.position = cur + new Vector2(-1, 0);
            
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (block.transform.position.x >= 4f)
            {
                return;
            }
            Debug.Log("->");
            Vector2 cur = block.transform.position;
            block.transform.position = cur + new Vector2(1, 0);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //네모는 회전 못함
            if(block.tag == "square")
            {
                Debug.Log("sqare");
                return;
            }
            Debug.Log("회전");
            block.transform.Rotate(0, 0, 90, Space.Self);
        }
    }

    void Spawn()
    {
        int block_rand = Random.Range(0, 3);
        int rand = Random.Range(0, 6);        
        block = Instantiate(blocks[block_rand], spawn_point[rand].position, spawn_point[rand].rotation);
        Rigidbody2D rigid = block.GetComponent<Rigidbody2D>();
        rigid.velocity = new Vector2(0 , -speed);
        Debug.Log(block.transform.position.x);
        //rigid.velocity = new Vector2(-1, -0.1f);
    }

    public void Move()
    {
        
    }
    
}
