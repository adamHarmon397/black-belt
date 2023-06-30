using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class death : MonoBehaviour
{
    public GameObject explosion;
    public movment movment;
    Vector3 startPos;
    Rigidbody2D rb;
    public Vector3 deathPos;
    public colect colect;
    public SpriteRenderer selfRen;
    public GameObject enemy;
    public lifeManager lifeManager;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        startPos = transform.position;
    }
    public void Death()
    {
        Instantiate(explosion, deathPos, Quaternion.identity);
        selfRen.enabled = false;
        Invoke("respawn", 1f); 
    }
    public void respawn()
    {
        lifeManager.hit();
        selfRen.enabled = true;
        transform.position = startPos;
        movment.zRotation = movment.startRotation;
        movment.orientation.rotation = Quaternion.Euler(0f, 0f, movment.zRotation);
        transform.rotation = Quaternion.Euler(0f, 0f, movment.zRotation);
        rb.velocity = Vector2.zero;
        colect.resetKey();
        enemy.SetActive(true);
    }
}
