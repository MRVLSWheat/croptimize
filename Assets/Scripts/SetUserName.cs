using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SetUserName : MonoBehaviour
{
    public TextMeshProUGUI userName;
    public TextMeshProUGUI wrongCredentials;
    public TMP_InputField userInputField;
    public TMP_InputField passwordInputField;

    public GameObject loadScreen;
    public GameObject loginScreen;

    private string fakeUserName = "Mercury";
    private string fakePassword = "Design";
    private string password;

    public void UserName()
    {
        userName.text = userInputField.text;
        password = passwordInputField.text;

        if (userName.text == fakeUserName && password == fakePassword)
        {
            wrongCredentials.text = "";
            loadScreen.SetActive(true);
            loginScreen.SetActive(false);
            Debug.Log("Login succesful");
        }
        else
        {
            wrongCredentials.text = "Incorrect credentials, please try again.";
            Debug.Log("Login failed");
        }

        userInputField.text = "";
        passwordInputField.text = "";
    }
}
