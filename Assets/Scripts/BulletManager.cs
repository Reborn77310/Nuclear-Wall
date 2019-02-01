using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletManager : MonoBehaviour
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

	void OnCollisionEnter()
	{
		Destroy(this.gameObject);
		print("lameredarthurlapute");
	}
}
