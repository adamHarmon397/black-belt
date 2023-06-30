using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
{
    public death death;
    public GameObject player;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "Player")
        {
            death.deathPos = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z);
            death.Death();
        }
    }
    
}
