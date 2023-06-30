using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    public Transform bulletTransfrom;
    Vector3 mousePos;
    private Camera camerab;
    public GameObject bullet;
    public bool canFire;
    private float timer;
    public float timeBetweenFireing;
    // Start is called before the first frame update
    void Start()
    {
        camerab = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
    }

    // Update is called once per frame
    void FixedUpdate()
        
    {
        mousePos = camerab.ScreenToWorldPoint(Input.mousePosition);
        Vector3 rotation = mousePos - transform.position;
        float rotZ = Mathf.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, rotZ);

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
        if (Input.GetMouseButtonDown(0) && canFire)
        {
            canFire = false;
            Instantiate(bullet, bulletTransfrom.position, Quaternion.identity);

        }
    }
}
