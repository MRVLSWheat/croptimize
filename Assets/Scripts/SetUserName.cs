using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SetUserName : MonoBehaviour
{
    public TextMeshProUGUI userName;
    public TMP_InputField userInputField;

    public void UserName()
    {
        userName.text = userInputField.text;
    }
}
