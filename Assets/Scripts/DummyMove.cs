using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DummyMove : MonoBehaviour
{
    public GameObject activeTrigger;
    public GameObject dummy;
    public GameObject dummyHead;
    public GameObject dummyInRoom;
    public GameObject dummyOutside;
    public GameObject lightIn;
    public GameObject activeSoundTrigger;
    public AudioSource myFx;
    public AudioClip ClipFx;

    private void OnTriggerEnter(Collider other)
    {
        if (this.CompareTag("DummyActiveT") && other.CompareTag("Player"))
        {
            activeTrigger.SetActive(true);
            activeSoundTrigger.SetActive(true);
        }
        else if (this.CompareTag("DummyMoveHead") && other.CompareTag("Player"))
        {
            dummy.SetActive(false);
            dummyHead.SetActive(true);
            lightIn.SetActive(true);
            dummyInRoom.SetActive(true);
            dummyOutside.SetActive(true);

        }
        else if (this.CompareTag("SoundTrigger2") && other.CompareTag("Player"))
        {
            myFx.PlayOneShot(ClipFx);
            activeSoundTrigger.SetActive(false);
        }
        else if (this.CompareTag("SoundTrigger3") && other.CompareTag("Player"))
        {
            myFx.PlayOneShot(ClipFx);
            Destroy(gameObject);
        }
        else if (this.CompareTag("DummyFirstEtaj") && other.CompareTag("Player"))
        {
            dummy.SetActive(false);
            dummyHead.SetActive(true);
            myFx.PlayOneShot(ClipFx);
        }
    }
}
