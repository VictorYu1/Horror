using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

public class Note : MonoBehaviour
{

    public GameObject Button_Up;
    public GameObject Delete_Note_Button;
    private RaycastHit hit;
    public AudioSource myFx;
    public AudioClip NoteUpFx;
    public GameObject noteUI;
    public GameObject noteUI1;
    public GameObject noteLeverRoom;
    public GameObject noteroom1;
    public GameObject noteroom2;
    public GameObject noteroom3;
    public GameObject noteroom4;
    public GameObject noteroom5;
    public GameObject noteroom6;
    public GameObject newsPaperUi;

    public GameObject touchPanel;
    public GameObject floatingJoystick;

    void FixedUpdate()
    {
        var forw = transform.TransformDirection(Vector3.forward);
        if (Physics.Raycast(transform.position, forw, out hit, 1.5f))
        {
            
            if (hit.collider.tag == "Note")
            {
                if (!noteUI.activeSelf)
                    Button_Up.SetActive(true);
                if (noteUI.activeSelf)
                    Delete_Note_Button.SetActive(true);
            } else if (hit.collider.tag == "NewsPaper") {
                if (!newsPaperUi.activeSelf)
                    Button_Up.SetActive(true);
                if (newsPaperUi.activeSelf)
                    Delete_Note_Button.SetActive(true);
            } else if (hit.collider.tag == "Note1") {
                if (noteUI1.activeSelf)
                    Button_Up.SetActive(true);
                if (noteUI1.activeSelf)
                    Delete_Note_Button.SetActive(true);
            } else if (hit.collider.tag == "NoteLeverRoom") {
                if (!noteLeverRoom.activeSelf)
                    Button_Up.SetActive(true);
                if (noteLeverRoom.activeSelf)
                    Delete_Note_Button.SetActive(true);
            } else if (hit.collider.tag == "NoteRoom1") {
                if (!noteroom1.activeSelf)
                    Button_Up.SetActive(true);
                if (noteroom1.activeSelf)
                    Delete_Note_Button.SetActive(true);
            } else if (hit.collider.tag == "NoteRoom2") {
                if (!noteroom2.activeSelf)
                    Button_Up.SetActive(true);
                if (noteroom2.activeSelf)
                    Delete_Note_Button.SetActive(true);
            } else if (hit.collider.tag == "NoteRoom3") {
                if (!noteroom3.activeSelf)
                    Button_Up.SetActive(true);
                if (noteroom3.activeSelf)
                    Delete_Note_Button.SetActive(true);
            } else if (hit.collider.tag == "NoteRoom4") {
                if (!noteroom4.activeSelf)
                    Button_Up.SetActive(true);
                if (noteroom4.activeSelf)
                    Delete_Note_Button.SetActive(true);
            } else if (hit.collider.tag == "NoteRoom5") {
                if (!noteroom5.activeSelf)
                    Button_Up.SetActive(true);
                if (noteroom5.activeSelf)
                    Delete_Note_Button.SetActive(true);
            } else if (hit.collider.tag == "NoteRoom6") {
                if (!noteroom6.activeSelf)
                    Button_Up.SetActive(true);
                if (noteroom6.activeSelf)
                    Delete_Note_Button.SetActive(true);
            }
	    }
        else
        {
            Button_Up.SetActive(false);
            Delete_Note_Button.SetActive(false);
        }
    }

    public void ButtonUseForNote()
    {
        if (hit.collider.tag == "Note")
        {
            myFx.PlayOneShot(NoteUpFx);
            noteUI.SetActive(true);
            touchPanel.SetActive(false);
            floatingJoystick.SetActive(false);
        }
    }

    public void ButtonUseForNote1()
    {
        if (hit.collider.tag == "Note1")
        {
            myFx.PlayOneShot(NoteUpFx);
            noteUI1.SetActive(true);
            touchPanel.SetActive(false);
            floatingJoystick.SetActive(false);
            
        } 
        else if (hit.collider.tag == "NoteLeverRoom")
        {
            myFx.PlayOneShot(NoteUpFx);
            noteLeverRoom.SetActive(true);
            touchPanel.SetActive(false);
            floatingJoystick.SetActive(false);
        }
        else if (hit.collider.tag == "NoteRoom1")
        {
            myFx.PlayOneShot(NoteUpFx);
            noteroom1.SetActive(true);
            touchPanel.SetActive(false);
            floatingJoystick.SetActive(false);
        }
        else if (hit.collider.tag == "NoteRoom2")
        {
            myFx.PlayOneShot(NoteUpFx);
            noteroom2.SetActive(true);
            touchPanel.SetActive(false);
            floatingJoystick.SetActive(false);
        }
        else if (hit.collider.tag == "NoteRoom3")
        {
            myFx.PlayOneShot(NoteUpFx);
            noteroom3.SetActive(true);
            touchPanel.SetActive(false);
            floatingJoystick.SetActive(false);
        }
        else if (hit.collider.tag == "NoteRoom4")
        {
            myFx.PlayOneShot(NoteUpFx);
            noteroom4.SetActive(true);
            touchPanel.SetActive(false);
            floatingJoystick.SetActive(false);
        }
        else if (hit.collider.tag == "NoteRoom5")
        {
            myFx.PlayOneShot(NoteUpFx);
            noteroom5.SetActive(true);
            touchPanel.SetActive(false);
            floatingJoystick.SetActive(false);
        }
        else if (hit.collider.tag == "NoteRoom6")
        {
            myFx.PlayOneShot(NoteUpFx);
            noteroom6.SetActive(true);
            touchPanel.SetActive(false);
            floatingJoystick.SetActive(false);
        }
    }

    public void ButtonUseForNewsPaper()
    {
        if (hit.collider.tag == "NewsPaper")
        {
            myFx.PlayOneShot(NoteUpFx);
            newsPaperUi.SetActive(true);
        }
    }

    public void DeleteNote()
    {
        noteUI.SetActive(false);
        noteUI1.SetActive(false);
        newsPaperUi.SetActive(false);
        noteLeverRoom.SetActive(false);
        noteroom1.SetActive(false);
        noteroom2.SetActive(false);
        noteroom3.SetActive(false);
        noteroom4.SetActive(false);
        noteroom5.SetActive(false);
        noteroom6.SetActive(false);
        touchPanel.SetActive(true);
        floatingJoystick.SetActive(true);
    }
}
