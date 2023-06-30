using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyAim : MonoBehaviour
{
    public Vector3 playerTransform;
    public GameObject player;
    public Transform Transfrom;
    public GameObject bullet;
    public bool canFire;
    private float timer;
    public float timeBetweenFireing;
    public Transform bulletTransfrom;
    void Start()
    {
        
    }
    void FixedUpdate()

    {
        playerTransform = player.transform.position ;
        Vector3 rotation = playerTransform - transform.position;
        float rotZ = Mathf.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, rotZ + 90);

        fire();
    }
    private void fire()
    {
        if (!canFire)
        {
            timer += Time.deltaTime;
            if (timer > timeBetweenFireing)
            {
                canFire = true;
                timer = 0;
            }
        }
        if (canFire)
        {
            canFire = false;
            Instantiate(bullet, bulletTransfrom.position, Quaternion.identity);

        }
    }
}
