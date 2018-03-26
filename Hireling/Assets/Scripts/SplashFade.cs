using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SplashFade : MonoBehaviour {
    //This script exists to make the logo fade out and the splash screen transition to the start screen.
    [Header("Records time in deltaTime from start of scene")]
    [SerializeField]
    private float fadeTime;

	// Update is called once per frame
	void Update () {
        fadeTime += Time.deltaTime;

        if (fadeTime >= 3)
        {
            FindObjectOfType<LevelManager>().LoadNextLevel();
        }

    }
}
