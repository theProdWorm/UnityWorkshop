using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) {
        if(!other.CompareTag("Player"))
            return;


        var chickenCounter = FindObjectOfType<ChickenCounter>();
        chickenCounter.chickensLeft--;

        Destroy(gameObject);
    }
}