using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
	public GameObject[] DifferentCubes;
	
	public void SpawnCube(GameObject cubeHit)
	{
		var random = Random.Range(0,4);
		var positionOnY = new Vector3(0,0.5f,0);
		var registerName = DifferentCubes[random].name;
		GameObject wantedCube = Instantiate(DifferentCubes[random], cubeHit.transform.position - positionOnY,Quaternion.identity);
		wantedCube.name = registerName;
	}
}
