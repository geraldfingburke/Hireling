using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;
using System.Xml.Serialization;

public class Item : MonoBehaviour
{

    //Item class used for all non-equippable items. Currently, items only have a resale value, for loot calculations.

    [Header("Name of the Item")]
    public string itemName;
    [Header("Gold Value of Item")]
    public int itemValue;
    [Header("Chance of Finding Item")]
    public float itemRarity;
}
