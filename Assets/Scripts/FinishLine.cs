using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLine : MonoBehaviour
{
    public GameObject Fireworks;

    private int _objectsInside = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (++_objectsInside < 4)
            return;

        Instantiate(Fireworks, transform.position, Quaternion.identity);
    }

    private void OnTriggerExit(Collider other)
    {
        _objectsInside--;
    }
}
