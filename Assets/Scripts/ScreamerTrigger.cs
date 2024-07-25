using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreamerTrigger : MonoBehaviour
{
    public GameObject _scream;
    public GameObject _shelf;
    public GameObject _shelfOpen;
    public GameObject _doll;
    public GameObject _dollMove;
    public GameObject _dollMove1;
    public GameObject _candle;
    public GameObject _dummy;
    public GameObject _dummyMove;
    public AudioSource myFx;
    public AudioClip ClipFx;

    private void OnTriggerEnter(Collider other)
    {
        if (this.CompareTag("ScreamTrigger") && other.CompareTag("Player")) 
        {
            _scream.SetActive(true);
        } 
        else if (this.CompareTag("ShelfTrigger") && other.CompareTag("Player"))
        {
            _shelf.SetActive(false);
            _shelfOpen.SetActive(true);
        }
        else if (this.CompareTag("Doll") && other.CompareTag("Player"))
        {
            myFx.PlayOneShot(ClipFx);
            _doll.SetActive(false);
            _dollMove.SetActive(true);
            _candle.SetActive(true);
            Destroy(gameObject);
        }
        else if (this.CompareTag("Doll1") && other.CompareTag("Player"))
        {
            _dollMove.SetActive(false);
            _candle.SetActive(false);
            _dollMove1.SetActive(true);
            Destroy(gameObject);
        }
        else if (this.CompareTag("Dummy2") && other.CompareTag("Player"))
        {
            _dummy.SetActive(false);
            _dummyMove.SetActive(true);
        }
    }
}
