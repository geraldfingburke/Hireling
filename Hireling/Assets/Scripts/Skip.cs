﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skip : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		if (Input.anyKeyDown)
        {
            FindObjectOfType<LevelManager>().LoadLevel("01a_Start");
        }
	}
}
