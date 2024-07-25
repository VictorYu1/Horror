using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum ItemType
{
    Box,
    Test,
    Message,
    Key
}

public class Item : MonoBehaviour
{
    public ItemType type;
    bool flag = false;
    public Text message = null;
    [TextArea]public string messageText;
    public GameObject obj = null;

    public void Interaction() 
    {
        if (type == ItemType.Box)
        {
            flag = !flag;
            GetComponentInParent<Animator>().SetBool("Open", flag);
            GetComponentInParent<Animator>().SetBool("Close", !flag);
        }
        if (type == ItemType.Test)
        {
            Destroy(gameObject);
        }
        if (type == ItemType.Message)
        {
            message.text = messageText;
        }
        if (type == ItemType.Key)
        {
            obj.GetComponent<Item>().type = ItemType.Box;
            Destroy(gameObject);
        }
    }
}
