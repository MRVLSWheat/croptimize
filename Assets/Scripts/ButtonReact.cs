using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ButtonReact : MonoBehaviour
{
    public AudioSource buttonPress;

    public void DeviceReact()
    {
        buttonPress.Play();
    }
}
