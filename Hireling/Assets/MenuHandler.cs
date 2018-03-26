using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuHandler : MonoBehaviour {

    public bool menuLoaded = false;
    public GameObject menu;
    private GameObject menuClone;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape) && !menuLoaded)
        {
            menuClone = Instantiate(menu, transform);
            menuLoaded = true;
        } else if (Input.GetKeyDown(KeyCode.Escape) && menuLoaded)
        {
            Destroy(menuClone);
            menuLoaded = false;
        }
	}
}
