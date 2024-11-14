using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ChickenCounter : MonoBehaviour
{
    public int chickensLeft;

    private void Awake() {
        chickensLeft = FindObjectsByType<Collectible>(FindObjectsSortMode.None).Length;
    }

    private void FixedUpdate() {
        print(chickensLeft);
    }
}
