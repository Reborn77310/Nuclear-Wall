using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
	public GameObject[] DifferentCubes;
	Vector3 positionOnY = new Vector3(0,0.5f,0);
	private void Start()
	{
		StartCoroutine("BaisserLesCubes");
	}

	public void SpawnCube(GameObject cubeHit)
	{
		var random = Random.Range(0,4);
		var registerName = DifferentCubes[random].name;
		GameObject wantedCube = Instantiate(DifferentCubes[random], cubeHit.transform.position - positionOnY,Quaternion.identity);
		wantedCube.name = registerName;
	}

	IEnumerator BaisserLesCubes()
	{
		yield return new WaitForSeconds(5);
		foreach (var go in GameObject.FindGameObjectsWithTag("Cubes"))
		{
			go.transform.position -= positionOnY;
		}
		StartCoroutine("BaisserLesCubes");
	}
}
