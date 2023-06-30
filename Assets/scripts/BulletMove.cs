using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{
    private Vector3 mousePos;
    private Camera camerab;
    private Rigidbody2D rb;
    public float speed;


    private void Start()
    {
        camerab = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        rb = GetComponent<Rigidbody2D>();
        mousePos = camerab.ScreenToWorldPoint(Input.mousePosition);
        Vector3 dir = mousePos - transform.position;
        Vector3 rotation = transform.position - mousePos;
        rb.velocity = new Vector2(dir.x, dir.y).normalized * speed;
        float rotZ = Mathf.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, rotZ + 90);
    }
    public void FixedUpdate()
    {
        
    }
}
