﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Counter : MonoBehaviour
{
    public TextMeshProUGUI CounterText;

    private int counter = 0;

    private void OnTriggerEnter(Collider other)
    {
        counter ++;
        CounterText.text = counter + " balls entered the box";
    }
}
