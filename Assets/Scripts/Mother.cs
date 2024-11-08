using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Mother : MonoBehaviour
{
    public SpriteRenderer Renderer;

    private void Start() {
        Renderer = GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player")){
            Renderer.enabled = false;
        }
    }
}
