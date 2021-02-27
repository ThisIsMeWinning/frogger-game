using UnityEngine;
using UnityEngine.SceneManagement;

public class Frog : MonoBehaviour {

	public Rigidbody2D rb;

	public static int lastScore;

	void Update () {

		if (Input.GetKeyDown(KeyCode.RightArrow))
			rb.MovePosition(rb.position + Vector2.right);
		else if (Input.GetKeyDown(KeyCode.LeftArrow))
			rb.MovePosition(rb.position + Vector2.left);
		else if (Input.GetKeyDown(KeyCode.UpArrow))
			rb.MovePosition(rb.position + Vector2.up);
		else if (Input.GetKeyDown(KeyCode.DownArrow))
			rb.MovePosition(rb.position + Vector2.down);

	}

	void OnTriggerEnter2D (Collider2D col)
	{
		if (col.tag == "Car")
		{
			Player.numberOfLives = Player.numberOfLives - 1;
			SceneManager.LoadScene(SceneManager.GetActiveScene().name);

			if (Player.numberOfLives == 0)
            {
				lastScore = Score.CurrentScore;
				
				SceneManager.LoadScene("GameOver");
				Debug.Log("WE LOST!");
				Score.CurrentScore = 0;
				Player.numberOfLives = 5;
			}
		}
	}
}
