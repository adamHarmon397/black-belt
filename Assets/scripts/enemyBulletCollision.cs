using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyBulletCollision : MonoBehaviour
{
    public GameObject self;
    GameObject player;
    public death Death;
    public void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        Death = player.GetComponent<death>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Player"))
        {
            Death.deathPos = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z);
            Death.Death();
            self.SetActive(false);
        }
        if (collision.CompareTag("wall"))
        {
            self.SetActive(false);
        }
    }
}
