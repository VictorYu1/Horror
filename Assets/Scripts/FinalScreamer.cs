using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalScreamer : MonoBehaviour
{
    public GameObject firstTrigger;
    public GameObject secondTrigger;
    public GameObject thirdTrigger;
    public GameObject fourTrigger;

    public GameObject firstDummy;
    public GameObject firstDummyMove;
    public GameObject secondDummyMove;
    public GameObject thirdDummyMove;
    public GameObject BananaMan;

    public GameObject theEndPanel;
    public bool PauseGame;

    public AudioSource myFx;
    public AudioClip ClipFx;

    private void OnTriggerEnter(Collider other)
    {
        if (this.CompareTag("firstTrigger") && other.CompareTag("Player"))
        {
            firstTrigger.SetActive(true);
            firstDummy.SetActive(true);
            BananaMan.SetActive(false);
            myFx.PlayOneShot(ClipFx);
        } 
        else if (this.CompareTag("firstMove") && other.CompareTag("Player"))
        {
            firstDummy.SetActive(false);
            secondTrigger.SetActive(true);
            firstDummyMove.SetActive(true);
            myFx.PlayOneShot(ClipFx);
        }
        else if (this.CompareTag("secondMove") && other.CompareTag("Player"))
        {
            firstDummyMove.SetActive(false);
            thirdTrigger.SetActive(true);
            secondDummyMove.SetActive(true);
            myFx.PlayOneShot(ClipFx);

        }
        else if (this.CompareTag("thirdMove") && other.CompareTag("Player"))
        {
            secondDummyMove.SetActive(false);
            fourTrigger.SetActive(true);
            thirdDummyMove.SetActive(true);
            myFx.PlayOneShot(ClipFx);
        }
        else if (this.CompareTag("finalScene") && other.CompareTag("Player"))
        {
            Pause();
        }
    }

    public void Pause()
    {
        myFx.PlayOneShot(ClipFx);
        theEndPanel.SetActive(true);
        Time.timeScale = 0f;
        PauseGame = true;
    }
}
