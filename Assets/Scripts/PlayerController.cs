using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rigid;
    Vector3 velocity = Vector3.zero;
    public float Speed = 10;
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        
    }

    void Move()
    {
        var horizontal = Input.GetAxis("Horizontal");
        velocity.x = horizontal * Time.deltaTime * Speed;
        rigid.velocity = velocity;
    }
}
