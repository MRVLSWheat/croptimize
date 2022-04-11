using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadingScreenTimer : MonoBehaviour
{
    float loadingTimer = 5.0f;
    bool loadingScreen = false;
    public GameObject loadScreen;
    public GameObject fieldSelectScreen;

    void Update()
    {
        if (loadingScreen == true)
        {
            LoadingStart();
        }
    }

    public void LoadingScreen()
    {
        loadingScreen = true;
    }

    void LoadingStart()
    {
        loadingTimer -= Time.deltaTime;
        if (loadingTimer < 0)
        {
            loadScreen.SetActive(false);
            fieldSelectScreen.SetActive(true);
            loadingScreen = false;
            loadingTimer = Random.Range(1.0f, 5.0f);
        }
    }
}
