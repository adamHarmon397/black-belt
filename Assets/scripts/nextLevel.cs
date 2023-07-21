using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextLevel : MonoBehaviour
{
    public string Scene;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            SceneManager.LoadScene(Scene);
            if (!buttonManager.c1)
            {
                buttonManager.c1 = true;
            }
            else if (!buttonManager.c2)
            {
                buttonManager.c2 = true;
            }
            else if(!buttonManager.c3)
            {
                buttonManager.c3 = true;
            }
            else if(!buttonManager.c4)
            {
                buttonManager.c4 = true;
            }
            else if(!buttonManager.c5)
            {
                buttonManager.c5 = true;
            }
        }
    }
}
