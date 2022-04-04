using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerificationScreenTimer : MonoBehaviour
{
    float verificationTimer = 5.0f;
    bool showScreen = false;
    public GameObject verificationScreen;
    public GameObject loginScreen;

    // Update is called once per frame
    void Update()
    {
        if (showScreen == true)
        {
            VerificationStart();
        }
    }

    public void ShowVerificationScreen()
    {
        showScreen = true;
    }

    void VerificationStart()
    {
        verificationTimer -= Time.deltaTime;
        if (verificationTimer < 0)
        {
            verificationScreen.SetActive(false);
            loginScreen.SetActive(true);
            showScreen = false;
            verificationTimer = 5.0f;
        }
    }
}
