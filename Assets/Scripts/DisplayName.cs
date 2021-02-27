using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayName : MonoBehaviour
{
	public Text displayName;

	void Start()
	{
		displayName.text = Player.playerName;
	}

}

