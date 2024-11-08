using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformerCamera : MonoBehaviour
{
    public GameObject Target;

    public Vector3 Offset;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //var offset = new Vector3(Offset.x, Offset.y, Offset.z);

        transform.position = Target.transform.position + Offset;
    }
}
