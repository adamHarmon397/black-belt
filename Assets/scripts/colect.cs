using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colect : MonoBehaviour
{
    public GameObject gate;
    public GameObject key;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            openGate();
        }
    }
    public void resetKey()
    {
        gate.SetActive(true);
        key.SetActive(true);
        
    }
    public void openGate()
    {
        gate.SetActive(false);
        key.SetActive(false);
    }
}
