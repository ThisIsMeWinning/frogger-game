using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSpeed : MonoBehaviour
{
	public void HandleInputData(int val)
	{
		if (val == 0)
		{
			Car.minSpeed = 2f;
			Car.maxSpeed = 4f;
			CarSpawner.spawnDelay = 1.5f;
		}
		if (val == 1)
		{
			Car.minSpeed = 6f;
			Car.maxSpeed = 8f;
			CarSpawner.spawnDelay = .2f;
		}
		if (val == 2)
		{
			Car.minSpeed = 10f;
			Car.maxSpeed = 12f;
			CarSpawner.spawnDelay = .1f;
		}
	}

}
