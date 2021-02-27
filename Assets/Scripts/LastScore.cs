using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LastScore : MonoBehaviour
{
	public Text lastScoreText;

	void Start()
	{
		lastScoreText.text = Frog.lastScore.ToString();
	}

}