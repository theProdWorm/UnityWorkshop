using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class MusicSphere : MonoBehaviour
{
    public AudioSource audioSource;

    public AudioClip clip;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(!other.CompareTag("Player"))
            return;

        enabled = false;
        audioSource.clip = clip;
    }
}
