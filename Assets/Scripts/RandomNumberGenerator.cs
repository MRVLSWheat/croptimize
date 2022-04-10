using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class RandomNumberGenerator : MonoBehaviour
{ 
    public GameObject[] weatherConditions;

    public int index;
    public int temperature;

    public GameObject parentFolder;

    public Transform point1;
    public Transform point2;
    public Transform point3;
    public Transform point4;
    public Transform point5;
    public Transform point6;
    public Transform point7;

    public TMP_Text day1;
    public TMP_Text day2;
    public TMP_Text day3;
    public TMP_Text day4;
    public TMP_Text day5;
    public TMP_Text day6;
    public TMP_Text day7;

    public void Start()
    {
        GenerateRandomTemperature();
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

        Debug.Log("Start temperature = " + temperature);

        day1.text = monday.ToString();
        day2.text = tuesday.ToString();
        day3.text = wednesday.ToString();
        day4.text = thursday.ToString();
        day5.text = friday.ToString();
        day6.text = saturday.ToString();
        day7.text = sunday.ToString();
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

        GameObject weatherParent = Instantiate(chosenImage, point1.position, Quaternion.identity) as GameObject;
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

        GameObject weatherParent = Instantiate(chosenImage, point2.position, Quaternion.identity) as GameObject;
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

        GameObject weatherParent = Instantiate(chosenImage, point3.position, Quaternion.identity) as GameObject;
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

        GameObject weatherParent = Instantiate(chosenImage, point4.position, Quaternion.identity) as GameObject;
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

        GameObject weatherParent = Instantiate(chosenImage, point5.position, Quaternion.identity) as GameObject;
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

        GameObject weatherParent = Instantiate(chosenImage, point6.position, Quaternion.identity) as GameObject;
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

        GameObject weatherParent = Instantiate(chosenImage, point7.position, Quaternion.identity) as GameObject;
        weatherParent.transform.SetParent(parentFolder.gameObject.transform);
    }
}
