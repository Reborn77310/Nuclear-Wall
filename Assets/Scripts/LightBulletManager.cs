using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightBulletManager : MonoBehaviour
{
    Vector3 velocity = Vector3.zero;
    Rigidbody2D rigid;
    public int Speed = 600;
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        velocity.y = Speed * Time.deltaTime;
    }

    void Update()
    {
        rigid.velocity = velocity;
    }

    void OnCollisionEnter2D(Collision2D col)
    {
		StartCoroutine("WaitForDestruction");
    }

    IEnumerator WaitForDestruction()
    {
		this.GetComponent<SpriteRenderer>().enabled = false;
		this.GetComponent<BoxCollider2D>().enabled = false;
		velocity = Vector3.zero;
		rigid.isKinematic = true;
        yield return new WaitForSeconds(2);
        Destroy(this.gameObject);
    }
}
