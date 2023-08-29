using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bomb : MonoBehaviour
{
    public ParticleSystem explosion;
    CircleCollider2D circleCol;
    GameObject player;
    public death Death;
    public AudioClip explosionClip;
    public bombRaycast bombRaycast;
    private void Start()
    {
        circleCol = gameObject.GetComponent<CircleCollider2D>();
        player = GameObject.FindGameObjectWithTag("Player");
        Death = player.GetComponent<death>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.tag == "enemy1" || collision.gameObject.tag == "bullet"  )
        {


            circleCol.radius = 1.5f;
            Invoke("Destroy", 0.4f);
        }
        
        if (collision.gameObject.tag == "Player")
        {
            circleCol.radius = 1.5f;
            Death.deathPos = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z);
            Death.Death();
            Invoke("Destroy", 0.2f);
        }
        if (collision.gameObject.tag == "bomb")
        {
            chain();
        }
    }
    
    public void chain()
    {
        circleCol.radius = 1;
        Invoke("Destroy", Random.Range(.3f, .5f));
    }
    private void Destroy()
    {
        
        AudioSource.PlayClipAtPoint(explosionClip, Camera.main.transform.position);
        explosion.Play();
        circleCol.radius = 0.5f;
        gameObject.SetActive(false);
    }
}
