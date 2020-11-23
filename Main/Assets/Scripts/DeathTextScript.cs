﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeathTextScript : MonoBehaviour
{
    Text text;
    public static int deathAmount;
    // Start is called before the first frame update
    void Start()
    {
      text = GetComponent<Text> ();
    }

    // Update is called once per frame
    void Update()
    {
      text.text = "Deaths: " + deathAmount.ToString();
    }
}
