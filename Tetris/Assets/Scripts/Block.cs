using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
   
  
    void Start()
    {
    }

    void Update()
    {        
        Rigidbody2D rigid = GetComponent<Rigidbody2D>();       
    }

    //부딪히면 멈춘다 -> 이 로직은 좋지 않다.
    //너무 예외가 많아
    /*void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("collision");
        Rigidbody2D rigid = GetComponent<Rigidbody2D>();
        if (transform.position.x - collision.transform.position.x < 1)
        {
            Debug.Log(transform.position.x);
            Debug.Log(collision.transform.position.x);
            rigid.velocity = new Vector2(0, 0);
        }
        else
        {
            Debug.Log("내려가");
        }
    }*/
}
