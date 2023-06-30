using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movment : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed;
    Vector3 moveDir;
    public Transform orientation;
    float verticalInput;
 
    public float zRotation;

    public float rotationSpeed;
    public float startRotation;

    public propulsion propulsion;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.freezeRotation = true;
        zRotation = startRotation;
        orientation = this.GetComponent<Transform>();
        transform.rotation = Quaternion.Euler(0f, 0f, zRotation);
    }
    private void FixedUpdate()
    {
        float verticalInput = Input.GetAxisRaw("Vertical");
        if (Input.GetKey(KeyCode.W))
        {
            moveDir = orientation.up * verticalInput;
            MovePlayer();
            propulsion.Propulsion();
        }
        else
        {
            propulsion.StopPropulsion();
        }
        if (Input.GetKey(KeyCode.A))
        {
            zRotation += Time.deltaTime * rotationSpeed;
            orientation.rotation = Quaternion.Euler(0f, 0f, zRotation);
            transform.rotation = Quaternion.Euler(0f, 0f, zRotation);
        }
        if (Input.GetKey(KeyCode.D))
        {
            zRotation -= Time.deltaTime * rotationSpeed;
            orientation.rotation = Quaternion.Euler(0f, 0f, zRotation);
            transform.rotation = Quaternion.Euler(0f, 0f, zRotation);
        }
    }

    void MovePlayer()
    {
        
        rb.AddForce(moveDir.normalized * speed, ForceMode2D.Force);
    }
}
//if (Input.GetKey(KeyCode.S))
    //    {
     //       moveDir = orientation.forward* verticalInput - orientation.up;
     //       MovePlayer();
     //   }
