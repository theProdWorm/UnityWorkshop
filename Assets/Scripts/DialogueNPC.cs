using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class DialogueNPC : MonoBehaviour
{
    public TextAsset manuscript;
    public Blabber dialogueManager;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(!other.CompareTag("Player"))
            return;

        var promptTMP = other.GetComponentInChildren<TextMeshPro>();
        promptTMP.enabled = true;

        var playerScript = other.GetComponent<PlatformerMovement>();
        playerScript.Interact += OnInteract;    
    }
    
    private void OnTriggerExit2D(Collider2D other)
    {
        if(!other.CompareTag("Player"))
            return;

        var promptTMP = other.GetComponentInChildren<TextMeshPro>();
        promptTMP.enabled = false;

        var playerScript = other.GetComponent<PlatformerMovement>();
        playerScript.Interact -= OnInteract;
    }

    public virtual void OnInteract()
    {
        dialogueManager.StartTalking(manuscript);
    }
}
