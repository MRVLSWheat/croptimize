using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class RandomNumberGenerator : MonoBehaviour
{ 
    public GameObject[] weatherConditions;
    public GameObject[] weatherBackgrounds;
    public GameObject[] weatherBackgroundFronts;
    public GameObject[] notifications;
    public GameObject[] thermometers;

    public Transform[] points;
    public TMP_Text[] days;   

    public GameObject parentFolder;
    public GameObject redPotato;

    public int index;
    public int temperature;
    public int combinedTemp;
    public int averageTemp;

    public TextMeshProUGUI homeScreenTemp;
    public TextMeshProUGUI groundShake;
    public TextMeshProUGUI groundShakeLog;
    public TextMeshProUGUI maxTempValue;
    public TextMeshProUGUI minTempValue;
    public TextMeshProUGUI time;

    public void DefineWeather()
    {
        GenerateRandomTemperature();
        RandomGroundShake();
        RandomTime();
        SetWeatherMonday();
        SetWeatherTuesday();
        SetWeatherWednesday();
        SetWeatherThursday();
        SetWeatherFriday();
        SetWeatherSaturday();
        SetWeatherSunday();
    }

    public void GenerateRandomTemperature()
    {
        temperature = Random.Range(0, 30);

        int monday = temperature + Random.Range(-4, 4);

        int tuesday = monday + Random.Range(-4, 4);

        int wednesday = tuesday + Random.Range(-4, 4);

        int thursday = wednesday + Random.Range(-4, 4);

        int friday = thursday + Random.Range(-4, 4);

        int saturday = friday + Random.Range(-4, 4);

        int sunday = saturday + Random.Range(-4, 4);

        days[0].text = monday.ToString();
        days[1].text = tuesday.ToString();
        days[2].text = wednesday.ToString();
        days[3].text = thursday.ToString();
        days[4].text = friday.ToString();
        days[5].text = saturday.ToString();
        days[6].text = sunday.ToString();

        combinedTemp = monday + tuesday + wednesday + thursday + friday + saturday + sunday;
        averageTemp = combinedTemp / 7;
        homeScreenTemp.text = averageTemp.ToString() + "°C";

        SetThermometerImage();

        int minTemp = Mathf.Min(monday, tuesday, wednesday, thursday, friday, saturday, sunday);
        minTempValue.text = minTemp.ToString() + "°C";

        int maxTemp = Mathf.Max(monday, tuesday, wednesday, thursday, friday, saturday, sunday);
        maxTempValue.text = maxTemp.ToString() + "°C";
    }

    private void RandomGroundShake()
    {
        int shakeNumber = Random.Range(0, 15);
        groundShake.text = shakeNumber.ToString() + "%";
        groundShakeLog.text = shakeNumber.ToString() + "%";
        
        if (shakeNumber >= 10)
        {
            notifications[1].SetActive(true);
            redPotato.SetActive(true);
        }
    }

    public void SetThermometerImage()
    {
        if (averageTemp > 25)
        {
            thermometers[2].SetActive(true);
            notifications[0].SetActive(true);
            weatherBackgrounds[2].SetActive(true);
            weatherBackgroundFronts[2].SetActive(true);
        }

        if (averageTemp < 5)
        {
            thermometers[1].SetActive(true);
            notifications[0].SetActive(true);
            weatherBackgrounds[1].SetActive(true);
            weatherBackgroundFronts[1].SetActive(true);
        }
        
        else
        {
            thermometers[0].SetActive(true);
            weatherBackgrounds[0].SetActive(true);
            weatherBackgroundFronts[0].SetActive(true);
        }
    }

    public void SetWeatherMonday()
    {
        if (temperature <= 5)
        {
            index = Random.Range(0, 4);
        }
        else
        {
            index = Random.Range(0, 3);
        }

        GameObject chosenImage = weatherConditions[index];

        GameObject weatherParent = Instantiate(chosenImage, points[0].position, Quaternion.identity) as GameObject;
        weatherParent.transform.SetParent(parentFolder.gameObject.transform);
    }

    public void SetWeatherTuesday()
    {
        if (temperature <= 5)
        {
            index = Random.Range(0, 4);
        }
        else
        {
            index = Random.Range(0, 3);
        }

        GameObject chosenImage = weatherConditions[index];

        GameObject weatherParent = Instantiate(chosenImage, points[1].position, Quaternion.identity) as GameObject;
        weatherParent.transform.SetParent(parentFolder.gameObject.transform);
    }

    public void SetWeatherWednesday()
    {
        if (temperature <= 5)
        {
            index = Random.Range(0, 4);
        }
        else
        {
            index = Random.Range(0, 3);
        }

        GameObject chosenImage = weatherConditions[index];

        GameObject weatherParent = Instantiate(chosenImage, points[2].position, Quaternion.identity) as GameObject;
        weatherParent.transform.SetParent(parentFolder.gameObject.transform);
    }

    public void SetWeatherThursday()
    {
        if (temperature <= 5)
        {
            index = Random.Range(0, 4);
        }
        else
        {
            index = Random.Range(0, 3);
        }

        GameObject chosenImage = weatherConditions[index];

        GameObject weatherParent = Instantiate(chosenImage, points[3].position, Quaternion.identity) as GameObject;
        weatherParent.transform.SetParent(parentFolder.gameObject.transform);
    }

    public void SetWeatherFriday()
    {
        if (temperature <= 5)
        {
            index = Random.Range(0, 4);
        }
        else
        {
            index = Random.Range(0, 3);
        }

        GameObject chosenImage = weatherConditions[index];

        GameObject weatherParent = Instantiate(chosenImage, points[4].position, Quaternion.identity) as GameObject;
        weatherParent.transform.SetParent(parentFolder.gameObject.transform);
    }

    public void SetWeatherSaturday()
    {
        if (temperature <= 5)
        {
            index = Random.Range(0, 4);
        }
        else
        {
            index = Random.Range(0, 3);
        }

        GameObject chosenImage = weatherConditions[index];

        GameObject weatherParent = Instantiate(chosenImage, points[5].position, Quaternion.identity) as GameObject;
        weatherParent.transform.SetParent(parentFolder.gameObject.transform);
    }

    public void SetWeatherSunday()
    {
        if (temperature <= 5)
        {
            index = Random.Range(0, 4);
        }
        else
        {
            index = Random.Range(0, 3);
        }

        GameObject chosenImage = weatherConditions[index];

        GameObject weatherParent = Instantiate(chosenImage, points[6].position, Quaternion.identity) as GameObject;
        weatherParent.transform.SetParent(parentFolder.gameObject.transform);
    }

    public void RandomTime()
    {
        int hours = Random.Range(0, 24);
        int minutes = Random.Range(0, 60);

        if (hours < 10 && minutes > 10)
        {
            time.text = "0" + hours + ":" + minutes + "h";
        }

        if (hours < 10 && minutes < 10)
        {
            time.text = "0" + hours + ":0" + minutes + "h";
        }

        if (hours > 10 && minutes < 10)
        {
            time.text = hours + ":0" + minutes + "h"; 
        }

        if (hours > 10 && minutes > 10)
        {
            time.text = hours + ":" + minutes + "h";
        }
    }
}
