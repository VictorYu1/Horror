using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class EventSound : MonoBehaviour
{
    AudioSource mySource;
    public AudioClip myClip;

    void Start()
    {
        mySource = GetComponent<AudioSource>();
    }

    public void VoidEventSound()
    {
        mySource.PlayOneShot(myClip);
    }
}
