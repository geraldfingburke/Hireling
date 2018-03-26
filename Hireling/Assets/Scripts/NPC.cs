using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class NPC : MonoBehaviour {

    [Header("The NPC's Capacity for Physical Feats")]
    public int str;
    [Header("The NPC's Capacity for Dexterous Feats")]
    public int dex;
    [Header("The NPC's Capactiy for Mental Feats")]
    public int wit;
    [Header("The NPC's Currently Equipped Gear")]
    public GameObject equipHead;
    public GameObject equipNeck;
    public GameObject equipShirt;
    public GameObject equipGloves;
    public GameObject equipRing;
    public GameObject equipPants;
    public GameObject equipShoes;
    [Header("Equipment Slots for General Items")]
    public GameObject equipSlot1;
    public GameObject equipSlot2;
    public GameObject equipSlot3;
    public GameObject equipSlot4;
    public GameObject equipSlot5;

    void Start ()
    {
        //Sets starting attributes for each NPC on level loaded. Resets when the gameobject or scene does.
        if (GetComponent<Human>() != null)
        {
            str = Random.Range(2, 8);
            dex = Random.Range(1, 6);
            wit = Random.Range(4, 10);
        } else if (GetComponent<Elf>() != null)
        {
            str = Random.Range(1, 6);
            dex = Random.Range(4, 10);
            wit = Random.Range(2, 8);
        } else if (GetComponent<Dwarf>() != null) {
            str = Random.Range(4, 10);
            dex = Random.Range(2, 8);
            wit = Random.Range(1, 6);
        }
        
    }

    //Sets attributes of currently selected NPC and progresses level
    public void SelectNPC()
    {
        GameManager.currentNPC = gameObject;
        WriteNPCFile();
    }

    void WriteNPCFile ()
    {
        string path = "Assets/characterFile.xml";

        StreamWriter writer = new StreamWriter(path, false);
        writer.WriteLine("Strength: " + str);
        writer.WriteLine("Dexterity: " + dex);
        writer.WriteLine("Wit: " + wit);
        writer.WriteLine("Head: " + equipHead);
        writer.WriteLine("Necklace: " + equipNeck);
        writer.WriteLine("Cuirass: " + equipShirt);
        writer.WriteLine("Gloves: " + equipGloves);
        writer.WriteLine("Ring: " + equipRing);
        writer.WriteLine("Grieves: " + equipPants);
        writer.WriteLine("Boots: " + equipShoes);
        writer.Close();
    }
}
