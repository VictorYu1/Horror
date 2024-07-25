using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scream : MonoBehaviour
{
    public AudioSource myFx;
    public AudioClip ClipFx;

    private void OnTriggerEnter(Collider other)
    {
        if (this.CompareTag("Screamer") && other.CompareTag("Player")) 
        {
            myFx.PlayOneShot(ClipFx);
        }
    }
}
