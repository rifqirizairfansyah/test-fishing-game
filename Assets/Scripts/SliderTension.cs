using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderTension : MonoBehaviour
{
    // Start is called before the first frame update
    public Slider slider;
    public Image successArea;
    public float speed = 1f;
    public float successMinValue = 20f;
    public float successMaxValue = 35f;
    public int successCount = 3;

    private float direction = 1f;
    private int currentSuccessCount = 0;

    void Start()
    {
        slider.minValue = 0f;
        slider.maxValue = 100f;
        slider.value = 0f;

        float successAreaHeight = successMaxValue - successMinValue;
        successArea.rectTransform.sizeDelta = new Vector2(successArea.rectTransform.sizeDelta.y, successAreaHeight);
        successArea.rectTransform.anchoredPosition = new Vector2(successArea.rectTransform.anchoredPosition.y, successMinValue);
    }

    void Update()
    {
        slider.value += direction * speed * Time.deltaTime;

        if (slider.value == slider.minValue || slider.value == slider.maxValue)
        {
            direction *= -1f;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (slider.value >= successMinValue && slider.value <= successMaxValue)
            {
                currentSuccessCount++;
                successArea.color = Color.green;
            }
            else
            {
                currentSuccessCount = 0;
                successArea.color = Color.green;
            }
        }

        if (currentSuccessCount >= successCount)
        {
            // player wins
            Debug.Log("You win!");
            currentSuccessCount = 0;
        }
    }
}
