﻿using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SensivitySlider : MonoBehaviour
{
    public Slider slider;
    public GameObject sliderValue;
    // Start is called before the first frame update
    void Start()
    {
        slider.value = InformationHolder.Sensivity;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnValueChanged(float newValue)
    {
        InformationHolder.Sensivity = slider.value;
        sliderValue.GetComponent<TextMeshProUGUI>().text = "Følsomhed: " + InformationHolder.Sensivity.ToString("0.0");
    }
}
