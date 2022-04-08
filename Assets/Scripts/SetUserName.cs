using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SetUserName : MonoBehaviour
{
    public TextMeshProUGUI userName;
    public TMP_InputField userInputField;
    public TMP_InputField passwordInputField;

    public void UserName()
    {
        userName.text = userInputField.text;
        userInputField.text = "";
        passwordInputField.text = "";
    }
}
