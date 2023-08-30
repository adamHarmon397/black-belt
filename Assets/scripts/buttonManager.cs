using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttonManager : MonoBehaviour
{
    
    public Button button2;
    public Button button3;
    public Button button4;
    public Button button5;
    public Button button6;
    public Button button7;
    public Button button8;
    public static bool c1 = false;
    public static bool c2 = false;
    public static bool c3 = false;
    public static bool c4 = false;
    public static bool c5 = false;
    public static bool c6 = false;
    public static bool c7 = false;

    private void Start()
    {
        button2.interactable = false;
        button3.interactable = false;
        button4.interactable = false;
        button5.interactable = false;
        button6.interactable = false;
        button7.interactable = false;
        button8.interactable = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (c1)
        {
            button2.interactable = true;
        }
        if (c2)
        {
            button3.interactable = true;
        }
        if (c3)
        {
            button4.interactable = true;
        }
        if (c4)
        {
            button5.interactable = true;
        }
        if (c5)
        {
            button6.interactable = true;
        }
        if (c6)
        {
            button7.interactable = true;
        }
        if (c7)
        {
            button8.interactable = true;
        }
    }
}
