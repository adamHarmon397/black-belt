using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelSelect : MonoBehaviour
{
    public string Scene;
    public void pressed()
    {
        SceneManager.LoadScene(Scene);
    }
}
