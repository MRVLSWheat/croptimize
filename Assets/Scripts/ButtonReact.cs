using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonReact : MonoBehaviour
{
    public GameObject settings;

    public void OpenSettings()
    {
        if (settings.activeInHierarchy)
        {
            settings.SetActive(false);
        }
        else
        {
            settings.SetActive(true);
        }
    }
}
