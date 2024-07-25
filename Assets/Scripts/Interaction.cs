using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interaction : MonoBehaviour
{
    public Text indicator;
    public Text messageText;
    public Button interactionButton;
    RaycastHit hit;

    private void Start()
    {
        interactionButton.onClick.AddListener(InteractionButton);
    }

    void InteractionButton()
    {
        hit.collider.GetComponent<Item>().Interaction();
    }

    void Update()
    {
        if (Physics.Raycast(transform.position, transform.forward, out hit, 2))
        {
            if (hit.collider.tag == "Item")
            {
                // indicator.enabled = true;
                // if (Input.GetKeyDown(KeyCode.E))
                // {
                //     hit.collider.GetComponent<Item>().Interaction();
                // }
                interactionButton.image.enabled = true;
                if (hit.collider.GetComponent<Item>().type != ItemType.Message)
                {
                    messageText.text = "";
                }
            } 
            else
            {
                interactionButton.image.enabled = false;
                // indicator.enabled = false;
                messageText.text = "";
            }
        }
        else
        {
            interactionButton.image.enabled = false;
            // indicator.enabled = false;
            messageText.text = "";
        }
    }
}
