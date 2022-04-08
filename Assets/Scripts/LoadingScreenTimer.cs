using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadingScreenTimer : MonoBehaviour
{
    public float loadingTimer;
    public GameObject loadScreen;
    public GameObject fieldSelectScreen;

    // Update is called once per frame
    void Update()
    {
        loadingTimer -= Time.deltaTime;
        if (loadingTimer < 0)
        {
            loadScreen.SetActive(false);
            fieldSelectScreen.SetActive(true);
        }
    }
}
