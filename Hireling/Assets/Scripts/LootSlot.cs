using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LootSlot : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Inventory.currentSelection != this)
        {
            GetComponent<Image>().color = new Color(1, 1, 1, 1);
        }
	}
}
