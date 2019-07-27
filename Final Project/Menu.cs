﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject m_menu;
    bool isEnabled = false;



    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        foreach (Touch touch in Input.touches)
        {
            if (touch.tapCount == 2) ToggleMenu();
        }

        if (Input.GetMouseButtonDown(1)) ToggleMenu();
    }

    void ToggleMenu()
    {
        isEnabled = !isEnabled;
        m_menu.SetActive(isEnabled);
    }
}
