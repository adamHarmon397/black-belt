using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class propulsion : MonoBehaviour
{
    public ParticleSystem system;
    public void Propulsion()
    {
        system.Play();
    }
    public void StopPropulsion()
    {
        system.Stop();
    }
}
