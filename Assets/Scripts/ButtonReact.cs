using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ButtonReact : MonoBehaviour
{
    public AudioSource buttonPress;

    // Update is called once per frame
    public void DeviceReact()
    {
        buttonPress.Play();
    }
}
