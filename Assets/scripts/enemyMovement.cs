using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMovement : MonoBehaviour
{
    public float speed;
    private float direction;
    private Rigidbody2D rb;
    public float maxY;
    public float minY;
    public float rotationSpeed;
    public Vector3 veloc;
    public GameObject self;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        direction = 1f;
        veloc = GetComponent<Rigidbody2D>().velocity;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(Vector2.up * speed * direction, ForceMode2D.Force);
        transform.Rotate(0, 0, 1f * rotationSpeed);
        if(veloc.magnitude > speed)
        {
            rb.velocity = rb.velocity.normalized * speed;
        }
    }
    private void Update()
    {
        if(transform.position.y >= maxY)
        {
            direction = -1f;
        }
        if (transform.position.y <= minY)
        {
            direction = 1f;
        }
    }
}
