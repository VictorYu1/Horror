using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrySound : MonoBehaviour
{
    public AudioSource myFx;
    public AudioClip ClipFx;

    private void OnTriggerEnter(Collider other)
    {
        if (this.CompareTag("SoundTrigger") && other.CompareTag("Player")) 
        {
            myFx.PlayOneShot(ClipFx);
        }
    }
}
