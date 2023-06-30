using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemydeath : MonoBehaviour
{
    public GameObject explosion;
    public Transform Pos;
    public GameObject enemy;
    public void Update()
    {
        if (enemy.active == false)
        {
            killed();
        }
    }
    public void killed()
    {
        Instantiate(explosion, Pos);
    }
}
