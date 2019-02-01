using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rigid;
    Vector3 velocity = Vector3.zero;
    public float Speed = 10;
    Transform shotPoint;
    public Sprite[] DifferentColors;
    SpriteRenderer avatarSprite;
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        shotPoint = GameObject.Find("shotPoint").transform;
        avatarSprite = GetComponent<SpriteRenderer>();
    }


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
        Instantiate(Resources.Load("Prefabs/Tirs/" + avatarSprite.sprite.name),shotPoint.transform.position,shotPoint.transform.rotation);
        ChangeColor();
    }

    void Move()
    {
        var horizontal = Input.GetAxis("Horizontal");
        velocity.x = horizontal * Time.deltaTime * Speed;
        rigid.velocity = velocity;
    }

    void ChangeColor()
    {
        var random = Random.Range(0,4);
        if(avatarSprite.sprite == DifferentColors[random])
        {
            ChangeColor();
        }
        else{
            avatarSprite.sprite = DifferentColors[random];
        }
    }
}
