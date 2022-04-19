using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotificationValues : MonoBehaviour
{
    public GameObject updateText;
    float textTimer = 3.0f;
    bool showText = false;

    void Update()
    {
        if (showText == true)
        {
            ShowUpdateText();
        }
    }

    public void ShowUpdate()
    {
        showText = true;
    }

    public void ShowUpdateText()
    {
        updateText.SetActive(true);
        textTimer -= Time.deltaTime;
        if (textTimer < 0)
        {
            updateText.SetActive(false);
            showText = false;
            textTimer = 3.0f;
        }
    }
}
