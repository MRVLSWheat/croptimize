using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class RandomNumberGenerator : MonoBehaviour
{
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
    }

    public void GenerateRandomTemperature()
    {
        int temperature = Random.Range(0, 30);

        int monday = temperature + Random.Range(-4, 4);

        int tuesday = monday + Random.Range(-4, 4);

        int wednesday = tuesday + Random.Range(-4, 4);

        int thursday = wednesday + Random.Range(-4, 4);

        int friday = thursday + Random.Range(-4, 4);

        int saturday = friday + Random.Range(-4, 4);

        int sunday = saturday + Random.Range(-4, 4);

        day1.text = monday.ToString();
        day2.text = tuesday.ToString();
        day3.text = wednesday.ToString();
        day4.text = thursday.ToString();
        day5.text = friday.ToString();
        day6.text = saturday.ToString();
        day7.text = sunday.ToString();
    }
}
