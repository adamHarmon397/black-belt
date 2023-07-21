using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class levelSelect : MonoBehaviour
{
    public string Scene;
    public AudioClip click;
    public void pressed()
    {
        AudioSource.PlayClipAtPoint(click, Camera.main.transform.position);
        Invoke("loadScene", 0.1f);
    }
    public void loadScene()
    {
        SceneManager.LoadScene(Scene);
    }
    
}
