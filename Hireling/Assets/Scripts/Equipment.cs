using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Equipment : MonoBehaviour {
    public enum Slot
    {
        Helmet, Necklace, Cuirass, Gloves, Ring, Greaves, Boots
    }

    [Header("Name of the Piece")]
    public string equipmentName;
    [Header("Where on the Character the Piece is Equipped")]
    public Slot equipmentSlot;
    public float defense;
    public float speed;
    public float luck;
    public Image icon;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
