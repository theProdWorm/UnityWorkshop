using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubeCameraMovement : MonoBehaviour
{
    public float Speed;
    
    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -16)
            return;
        
        transform.position += Vector3.down * (Time.deltaTime * Speed);
    }
}
