using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotherChimken : DialogueNPC
{
    public TextAsset winDialogue;

    public override void OnInteract()
    {
        int chickenCount = FindObjectOfType<ChickenCounter>().chickensLeft;
        
        dialogueManager.StartTalking(chickenCount > 0 ? manuscript : winDialogue);
    }
}
