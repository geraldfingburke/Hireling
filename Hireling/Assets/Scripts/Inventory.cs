using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour {

    List<Item> items = new List<Item>();
    List<Equipment> equipment = new List<Equipment>();

    public static GameObject helmet;
    public static GameObject necklace;
    public static GameObject cuirass;
    public static GameObject gloves;
    public static GameObject ring;
    public static GameObject greaves;
    public static GameObject boots;

    public static GameObject currentSelection;

    public static GameObject lootOne;
    public static GameObject lootTwo;
    public static GameObject lootThree;
    public static GameObject lootFour;
    public static GameObject lootFive;

    public static GameObject itemOne;
    public static GameObject itemTwo;
    public static GameObject itemThree;
    public static GameObject itemFour;
    public static GameObject itemFive;
    public static GameObject itemSix;
    public static GameObject itemSeven;
    public static GameObject itemEight;
    public static GameObject itemNine;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        currentSelection.GetComponent<Image>().color = new Color(1, 1, 1, .5f);
	}

    public void AddItem (Item item)
    {
        if (items.Count < 10)
        {
            items.Add(item);
        } else if (items.Count >= 10)
        {
            Debug.Log("Cannot Add Item, inventory full");
        }
    }

    public void RemoveItem (Item item)
    {
        if (items.Count > 0)
        {
            items.Remove(item);
        } else if (items.Count <= 0)
        {
            Debug.Log("No Item To Remove");
        }
    }

    public void Equip (Equipment equipment)
    {
        switch (equipment.equipmentSlot)
        {
            case Equipment.Slot.Helmet:
                helmet = equipment.gameObject;
                break;
            case Equipment.Slot.Necklace:
                necklace = equipment.gameObject;
                break;
            case Equipment.Slot.Cuirass:
                cuirass = equipment.gameObject;
                break;
            case Equipment.Slot.Gloves:
                gloves = equipment.gameObject;
                break;
            case Equipment.Slot.Ring:
                ring = equipment.gameObject;
                break;
            case Equipment.Slot.Greaves:
                greaves = equipment.gameObject;
                break;
            case Equipment.Slot.Boots:
                boots = equipment.gameObject;
                break;
        }
    }

    public void SlotItem (GameObject slot)
    {
        if (currentSelection.GetComponent<Item>() != null)
        {
            switch (slot.GetComponent<ItemSlot>().itemSlot)
            {
                case ItemSlot.Slot.SlotOne:
                    itemOne = currentSelection;
                    break;
                case ItemSlot.Slot.SlotTwo:
                    itemTwo = currentSelection;
                    break;
                case ItemSlot.Slot.SlotThree:
                    itemThree = currentSelection;
                    break;
                case ItemSlot.Slot.SlotFour:
                    itemFour = currentSelection;
                    break;
                case ItemSlot.Slot.SlotFive:
                    itemFive = currentSelection;
                    break;
                case ItemSlot.Slot.SlotSix:
                    itemSix = currentSelection;
                    break;
                case ItemSlot.Slot.SlotSeven:
                    itemSeven = currentSelection;
                    break;
                case ItemSlot.Slot.SlotEight:
                    itemEight = currentSelection;
                    break;
                case ItemSlot.Slot.SlotNine:
                    itemNine = currentSelection;
                    break;
            }
        } 
    }

    public void Select (GameObject obj) 
    {
        currentSelection = obj;
    }
}
