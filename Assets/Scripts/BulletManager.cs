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

	void OnCollisionEnter2D(Collision2D col)
	{
		string[] splitArray = col.gameObject.name.Split(char.Parse("_"));
		if ((splitArray[1] + "(Clone)") == this.gameObject.name)
		{
			Destroy(col.gameObject);
		}
		else
		{
			GameObject.Find("GameManager").GetComponent<GameManager>().SpawnCube(col.gameObject);
		}
		Destroy(this.gameObject);
	}
}
