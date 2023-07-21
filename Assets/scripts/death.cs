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
    public GameObject[] enemy;
    public lifeManager lifeManager;
    public AudioClip explosionClip;
    public CapsuleCollider2D playerCollider2D;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        startPos = transform.position;
    }
    public void Death()
    {
        AudioSource.PlayClipAtPoint(explosionClip, Camera.main.transform.position);
        Instantiate(explosion, deathPos, Quaternion.identity);
        selfRen.enabled = false;
        movment.enabled = false;
        playerCollider2D.enabled = false;
        rb.velocity = new Vector2(0, 0);
        Invoke("respawn", 1f); 
    }
    public void respawn()
    {
        lifeManager.hit();
        selfRen.enabled = true;
        movment.enabled = true;
        playerCollider2D.enabled = true;
        movment.fuelAmount = 10;
        transform.position = startPos;
        movment.zRotation = movment.startRotation;
        movment.orientation.rotation = Quaternion.Euler(0f, 0f, movment.zRotation);
        transform.rotation = Quaternion.Euler(0f, 0f, movment.zRotation);
        rb.velocity = Vector2.zero;

        colect.resetKey();
        for (int i = 0; i < enemy.Length; i++)
        {
            // only the one matching i == which will be on, all others will be off
            enemy[i].SetActive(true);
        }

    }
}
