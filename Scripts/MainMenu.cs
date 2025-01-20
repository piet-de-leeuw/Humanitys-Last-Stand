using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }

    public void BacktoMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void Credit()
    {
        SceneManager.LoadScene(4);
    }

    public void Quit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

}
