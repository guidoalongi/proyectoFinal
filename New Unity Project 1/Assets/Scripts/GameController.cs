﻿using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {


	public GameObject hazard;
	public Vector3 spawnValues;	
	public int hazardCount;
	public float spawnWait;
	public float startWait;
	public float waveWait;
	void Start ()
	{
		StartCoroutine (SpawnWaves ());

	}	


	IEnumerator SpawnWaves ()
	{
		yield return new WaitForSeconds (startWait);
	while (true)
		{
for (int i = 0; i < hazardCount; i++)
		{
			Vector3 spawnPosition = new Vector3 ( spawnValues.x,Random.Range (spawnValues.y - 2, spawnValues.y), spawnValues.z);
				Quaternion spawnRotation = new Quaternion(0,0,0,0);
		Instantiate (hazard, spawnPosition, spawnRotation);
			yield return new WaitForSeconds (spawnWait);
		}
		yield return new WaitForSeconds (waveWait);
	}
	}
}
