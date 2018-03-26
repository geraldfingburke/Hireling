using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

    public void LoadLevel(string name)
    {
        SceneManager.LoadScene(name);
    }

    public void LoadNextLevel()
    {
        int i = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(i + 1);
    }

    public void LoadPreviousLevel()
    {
        int i = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(i - 1);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
