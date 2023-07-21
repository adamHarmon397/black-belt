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

    public float fuelAmount;
    public float refillSpeed;


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
        if (fuelAmount <= 0 )
        {
            fuelAmount = 0;
        }
        if (fuelAmount >= 10)
        {
            fuelAmount = 10;
        }
        float verticalInput = Input.GetAxisRaw("Vertical");
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow) && fuelAmount > 0)
        {
            moveDir = orientation.up * verticalInput;
            MovePlayer();
            propulsion.Propulsion();
            fuelAmount -= Time.deltaTime;
        }
        else
        {
            propulsion.StopPropulsion();
        }
        if (!Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            fuelAmount += Time.deltaTime * refillSpeed;
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow) && fuelAmount > 0)
        {
            zRotation += Time.deltaTime * rotationSpeed;
            orientation.rotation = Quaternion.Euler(0f, 0f, zRotation);
            transform.rotation = Quaternion.Euler(0f, 0f, zRotation);
            fuelAmount -= Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow) && fuelAmount > 0)
        {
            zRotation -= Time.deltaTime * rotationSpeed;
            orientation.rotation = Quaternion.Euler(0f, 0f, zRotation);
            transform.rotation = Quaternion.Euler(0f, 0f, zRotation);
            fuelAmount -= Time.deltaTime;
        }
    }

    void MovePlayer()
    {
        rb.AddForce(moveDir.normalized * speed, ForceMode2D.Force);
    }
}
