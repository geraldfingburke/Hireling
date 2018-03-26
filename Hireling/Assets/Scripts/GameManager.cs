using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    [Header("Currently active NPC")]
    public static GameObject currentNPC;

    public Text currentNPCStrText;
    public Text currentNPCDexText;
    public Text currentNPCWitText;

    void Update ()
    {
        currentNPCStrText.text = currentNPC.GetComponent<NPC>().str.ToString();
        currentNPCDexText.text = currentNPC.GetComponent<NPC>().dex.ToString();
        currentNPCWitText.text = currentNPC.GetComponent<NPC>().wit.ToString();
    }
}
