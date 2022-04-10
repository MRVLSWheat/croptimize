using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using CodeMonkey.Utils;

public class Window_Graph : MonoBehaviour
{
    [SerializeField] private Sprite circleSprite;
    private RectTransform graphContainer;

    private void Awake()
    {
        graphContainer = transform.Find("graphContainer").GetComponent<RectTransform>();
        int randomNumber = Random.Range(20, 80);

        int one = randomNumber + Random.Range(-4, 4);

        int two = one + Random.Range(-4, 4);

        int three = two + Random.Range(-4, 4);

        int four = three + Random.Range(-4, 4);

        int five = four + Random.Range(-4, 4);

        int six = five + Random.Range(-4, 4);

        int seven = six + Random.Range(-4, 4);

        int eight = seven + Random.Range(-4, 4);

        int nine = eight + Random.Range(-4, 4);

        int ten = nine + Random.Range(-4, 4);

        int eleven = ten + Random.Range(-4, 4);

        int twelve = eleven + Random.Range(-4, 4);

        int thirdteen = twelve + Random.Range(-4, 4);

        int fourteen = thirdteen + Random.Range(-4, 4);

        List<int> valueList = new List<int>() {one, two, three, four, five, six, seven, eight, nine, ten, eleven, twelve, thirdteen, fourteen};
        ShowGraph(valueList);

        Debug.Log("Start moisture = " + randomNumber);
    }

    private GameObject CreateCircle(Vector2 anchoredPosition)
    {
        GameObject gameObject = new GameObject("Circle", typeof(Image));
        gameObject.transform.SetParent(graphContainer, false);
        gameObject.GetComponent<Image>().sprite = circleSprite;
        RectTransform rectTransform = gameObject.GetComponent<RectTransform>();
        rectTransform.anchoredPosition = anchoredPosition;
        rectTransform.sizeDelta = new Vector2(11, 11);
        rectTransform.anchorMin = new Vector2(0, 0);
        rectTransform.anchorMax = new Vector2(0, 0);
        return gameObject;
    }

    private void ShowGraph(List<int> valueList)
    {
        float graphHeight = graphContainer.sizeDelta.y;
        float yMaximum = 100f;
        float xSize = 50f;

        GameObject lastCircleGameObject = null;

        for (int i = 0; i < valueList.Count; i++)
        {
            float xPosition = xSize + i * xSize -45;
            float yPosition = (valueList[i] / yMaximum) * graphHeight;
            
            GameObject circleGameObject = CreateCircle(new Vector2(xPosition, yPosition));
            
            if (lastCircleGameObject != null)
            {
                CreateDotConnection(lastCircleGameObject.GetComponent<RectTransform>().anchoredPosition, circleGameObject.GetComponent<RectTransform>().anchoredPosition);
            }
            lastCircleGameObject = circleGameObject;
        }
    }

    private void CreateDotConnection(Vector2 dotPositionA, Vector2 dotPositionB)
    {
        GameObject gameObject = new GameObject("dotConnection", typeof(Image));
        gameObject.transform.SetParent(graphContainer, false);
        gameObject.GetComponent<Image>().color = new Color(1, 1, 1, .5f);
        RectTransform rectTransform = gameObject.GetComponent<RectTransform>();
        Vector2 dir = (dotPositionB - dotPositionA).normalized;
        float distance = Vector2.Distance(dotPositionA, dotPositionB);
        rectTransform.anchorMin = new Vector2(0, 0);
        rectTransform.anchorMax = new Vector2(0, 0);
        rectTransform.sizeDelta = new Vector2(distance, 3f);
        rectTransform.anchoredPosition = dotPositionA + dir * distance * .5f;
        rectTransform.localEulerAngles = new Vector3(0, 0, UtilsClass.GetAngleFromVectorFloat(dir));
    }
}
