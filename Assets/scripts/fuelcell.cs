using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fuelcell : MonoBehaviour
{
    public movment movment;
    public GameObject fuel;
    public Image fuelRend;
    public Sprite[] fuelSprite;
    private void Start()
    {
        fuelRend = fuel.GetComponent<Image>();
    }
    void Update()
    {
        if (movment.fuelAmount >= 9.8)
        {
            fuelRend.sprite = fuelSprite[0];
        }
        else if (movment.fuelAmount >= 9.1)
        {
            fuelRend.sprite = fuelSprite[1];
        }
        else if (movment.fuelAmount >= 8.1)
        {
            fuelRend.sprite = fuelSprite[2];
        }
        else if (movment.fuelAmount >= 7.1)
        {
            fuelRend.sprite = fuelSprite[3];
        }
        else if (movment.fuelAmount >= 6.1)
        {
            fuelRend.sprite = fuelSprite[4];
        }
        else if (movment.fuelAmount >= 5.1)
        {
            fuelRend.sprite = fuelSprite[5];
        }
        else if (movment.fuelAmount >= 4.1)
        {
            fuelRend.sprite = fuelSprite[6];
        }
        else if (movment.fuelAmount >= 3.1)
        {
            fuelRend.sprite = fuelSprite[7];
        }
        else if (movment.fuelAmount >= 2.1)
        {
            fuelRend.sprite = fuelSprite[8];
        }
        else if (movment.fuelAmount >= 1.1)
        {
            fuelRend.sprite = fuelSprite[9];
        }
        else if(movment.fuelAmount >= 0)
        {
            fuelRend.sprite = fuelSprite[10];
        }
    }
}
