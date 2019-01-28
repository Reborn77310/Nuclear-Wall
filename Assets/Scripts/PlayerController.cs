using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rigid;
    Vector3 velocity = Vector3.zero;
    public float Speed = 10;
    Transform shotPoint;
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        shotPoint = GameObject.Find("shotPoint").transform;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        if(Input.GetKeyDown(KeyCode.O))
        {
            NormalShot();
        }
    }

    void NormalShot()
    {
        Instantiate(Resources.Load("Prefabs/normalShot"),shotPoint.transform.position,shotPoint.transform.rotation);
    }

    void Move()
    {
        var horizontal = Input.GetAxis("Horizontal");
        velocity.x = horizontal * Time.deltaTime * Speed;
        rigid.velocity = velocity;
    }
}
