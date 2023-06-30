using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class lifeManager : MonoBehaviour
{
    public int lifeNum;
    public Text text;
    public void hit()
    {
        lifeNum -= 1;
    }

    public void Update()
    {
        text.text = lifeNum.ToString();
        if (lifeNum <= 0)
        {
            SceneManager.LoadScene(5);
        }
    }
}
