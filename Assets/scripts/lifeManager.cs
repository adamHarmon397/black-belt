using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class lifeManager : MonoBehaviour
{
    public int lifeNum;
    public int numofHearts;
    public Image[] hearts;
    public void hit()
    {
        lifeNum -= 1;
    }

    public void Update()
    {
        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < lifeNum)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }
        }
        if (lifeNum <= 0)
        {
            SceneManager.LoadScene(5);
        }

    }
}
