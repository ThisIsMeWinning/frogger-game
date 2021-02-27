using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{

    public static int numberOfLives = 5;

	public static string playerName;

	public InputField inputField;

	public void SetName()
    {
		playerName = inputField.text;
    }

	public void HandleInputData(int val)
	{
		if (val == 0)
		{
			numberOfLives = 5;
		}
		if (val == 1)
		{
			numberOfLives = 10;
		}
		if (val == 2)
		{
			numberOfLives = 15;
		}
	}
}
