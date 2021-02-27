using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    public void Play()
    {
        SceneManager.LoadScene("Main");
    }

    public void Options()
    {
        SceneManager.LoadScene("Options");
    }

    public void Back()
    {
        SceneManager.LoadScene("Menu");
    }

    public void Quit()
    {
        Application.Quit();
        Debug.Log("Game QUIT");
    }

}
