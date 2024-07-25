using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;
public class PlayerMuvment : MonoBehaviour
{
    
    public float speed = 1;
    Vector2 velocity;
    public Transform playerCamera;
    public FloatingJoystick floatingJoystick;
    private float Hor, Ver;
    Rigidbody rigidb;

    public AudioSource myFx;
    public AudioClip ClipFx;
    public Text txt;
    public int Energy;
    public GameObject Light;
    public bool onLight;
    public float scet;

    public GameObject Button_Up;
    private RaycastHit hit;
    public AudioClip UpFx;

    public List<System.Func<float>> speedOverrides = new List<System.Func<float>>();

    private void Start() {
        rigidb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
       transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x,playerCamera.rotation.eulerAngles.y, transform.rotation.eulerAngles.z);
      
       Hor = floatingJoystick.Horizontal;
       Ver = floatingJoystick.Vertical;
    
        float movingSpeed = speed; 
        if (speedOverrides.Count > 0)
            movingSpeed = speedOverrides[speedOverrides.Count - 1]();
        velocity.y = Ver * movingSpeed * Time.deltaTime;
        velocity.x = Hor * movingSpeed * Time.deltaTime;
        transform.Translate(velocity.x, 0, velocity.y);

        var forw = transform.TransformDirection(Vector3.forward);
        if (Physics.Raycast(transform.position, forw, out hit, 1.5f))
        {
            
            if (hit.collider.tag == "Battery")
            {
                Button_Up.SetActive(true);
            }
            
	    }
        else
        {
            Button_Up.SetActive(false);
        }
    }

    void Update() 
    {
        txt.text = Energy + "%";
        if (onLight == true) 
        {
            scet += 1 * Time.deltaTime;
            if (scet >= 2) 
            {        
                Energy -= 1;
                scet = 0;
            }
        }

        if (Energy >= 100)
        {
            Energy = 100;
        }

        if (Energy <= 0) 
        {
            onLight = false;
            Light.SetActive (false);
            Energy = 0;
        }

    }

    public void FlashLightButton()
    {
        
        myFx.PlayOneShot(ClipFx);
        if (onLight == false && Energy > 0) 
        {
                
            Light.SetActive (true);
            onLight = true;
        }
        else
        {
            Light.SetActive (false);
            onLight = false;
        }    
        
    }

    public void ButtonUse()
    {
        if (hit.collider.tag == "Battery")
        {
            Energy += 25;
            myFx.PlayOneShot(UpFx);
            Destroy(hit.collider.gameObject);
            
        }
    }

    
}
