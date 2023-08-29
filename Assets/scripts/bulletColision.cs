using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletColision : MonoBehaviour
{
    public GameObject self;
    public GameObject enemy1;
    
    public void Start()
    {
        enemy1 = GameObject.FindGameObjectWithTag("enemy1");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.CompareTag("enemy1"))
        {

            collision.gameObject.SetActive(false);
            self.SetActive(false);
        }
        if (collision.CompareTag("wall"))
        {
            self.SetActive(false);
        }
        if (collision.CompareTag("bomb"))
        {
            self.SetActive(false);
        }
    }
}
