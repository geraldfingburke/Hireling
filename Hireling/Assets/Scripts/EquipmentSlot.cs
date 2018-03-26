using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EquipmentSlot : MonoBehaviour {

    private Inventory inventory;

    public Equipment.Slot equipmentSlot;

    private string equippedName;
    private float equippedDefense;
    private float equippedSpeed;
    private float equippedLuck;
    private Image equippedIcon;
	// Use this for initialization
	void Start () {
        inventory = GetComponent<Inventory>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D (Collider2D col)
    {
        if (col.GetComponent<Equipment>().equipmentSlot == equipmentSlot)
        {
            equippedName = col.GetComponent<Equipment>().equipmentName;
            equippedDefense = col.GetComponent<Equipment>().defense;
            equippedSpeed = col.GetComponent<Equipment>().speed;
            equippedLuck = col.GetComponent<Equipment>().luck;
            equippedIcon = col.GetComponent<Equipment>().icon;
        }
    }
}
