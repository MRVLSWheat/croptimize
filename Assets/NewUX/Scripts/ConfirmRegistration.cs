using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ConfirmRegistration : MonoBehaviour
{
    public void NewScene()
    {
            SceneManager.LoadScene("NewMainMenu");
    }
}
