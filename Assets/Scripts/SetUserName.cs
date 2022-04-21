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
    public GameObject graphObject;
    public GameObject weatherObject;
    public GameObject soilObject;

    private Window_Graph setGraph;
    private RandomSoilTemp soilTemp;
    private RandomNumberGenerator setWeather;

    private string fakeUserName = "Mercury";
    private string fakePassword = "Design";
    private string password;

    public int firstLogin = 0;

    public void Awake()
    {
        setGraph = graphObject.GetComponent<Window_Graph>();
        setWeather = weatherObject.GetComponent<RandomNumberGenerator>();
        soilTemp = soilObject.GetComponent<RandomSoilTemp>();
    }

    public void UserName()
    {
        userName.text = userInputField.text;
        password = passwordInputField.text;

        if (userName.text == fakeUserName && password == fakePassword)
        {
            wrongCredentials.text = "";
            loadScreen.SetActive(true);
            loginScreen.SetActive(false);
            Debug.Log("Login successful");
            
            if (firstLogin == 0)
            {
                setGraph.DefineMoisture();
                setWeather.DefineWeather();
                soilTemp.DefineSoilTemp();
                firstLogin = 1;
            }
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
