using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyBulletMove : MonoBehaviour
{
    public GameObject player;
    private Vector3 playerTransform;
    private Rigidbody2D rb;
    public float speed;


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player");
        playerTransform = player.transform.position;
        Vector3 dir = playerTransform - transform.position;
        Vector3 rotation = transform.position - playerTransform;
        rb.velocity = new Vector2(dir.x, dir.y).normalized * speed;
        float rotZ = Mathf.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, rotZ + 90);
    }
}
