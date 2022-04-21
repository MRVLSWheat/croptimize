using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class RandomSoilTemp : MonoBehaviour
{
    public GameObject[] soilBackgrounds;
    public GameObject[] soilBackgroundsFront;
    public GameObject[] soilThermometers;
    public TMP_Text[] days;

    public GameObject notification;
    public TMP_Text homeScreenSoilTemp;
    public TMP_Text minSoilTempValue;
    public TMP_Text maxSoilTempValue;


    public int combinedSoilTemp;
    public int averageSoilTemp;

    public void DefineSoilTemp()
    {
        GenerateSoilTemperature();
        SetSoilThermometerImage();
    }

    public void GenerateSoilTemperature()
    {
        int temperature = Random.Range(4, 17);

        int monday = temperature + Random.Range(-2, 2);

        int tuesday = monday + Random.Range(-2, 2);

        int wednesday = tuesday + Random.Range(-2, 2);

        int thursday = wednesday + Random.Range(-2, 2);

        int friday = thursday + Random.Range(-2, 2);

        int saturday = friday + Random.Range(-2, 2);

        int sunday = saturday + Random.Range(-2, 2);

        days[0].text = monday.ToString() + "°C";
        days[1].text = tuesday.ToString() + "°C";
        days[2].text = wednesday.ToString() + "°C";
        days[3].text = thursday.ToString() + "°C";
        days[4].text = friday.ToString() + "°C";
        days[5].text = saturday.ToString() + "°C";
        days[6].text = sunday.ToString() + "°C";

        combinedSoilTemp = monday + tuesday + wednesday + thursday + friday + saturday + sunday;
        averageSoilTemp = combinedSoilTemp / 7;
        homeScreenSoilTemp.text = averageSoilTemp.ToString() + "°C";

        int minSoilTemp = Mathf.Min(monday, tuesday, wednesday, thursday, friday, saturday, sunday);
        minSoilTempValue.text = minSoilTemp.ToString() + "°C";

        int maxSoilTemp = Mathf.Max(monday, tuesday, wednesday, thursday, friday, saturday, sunday);
        maxSoilTempValue.text = maxSoilTemp.ToString() + "°C";
    }

    public void SetSoilThermometerImage()
    {
        if (averageSoilTemp > 14)
        {
            soilThermometers[2].SetActive(true);
            notification.SetActive(true);
            soilBackgrounds[2].SetActive(true);
            soilBackgroundsFront[2].SetActive(true);
        }

        if (averageSoilTemp < 7)
        {
            soilThermometers[1].SetActive(true);
            notification.SetActive(true);
            soilBackgrounds[1].SetActive(true);
            soilBackgroundsFront[1].SetActive(true);
        }

        else
        {
            soilThermometers[0].SetActive(true);
            soilBackgrounds[0].SetActive(true);
            soilBackgroundsFront[0].SetActive(true);
        }
    }
}
