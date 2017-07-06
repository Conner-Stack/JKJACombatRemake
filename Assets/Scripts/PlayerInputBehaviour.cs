using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputBehaviour : MonoBehaviour
{
    public float walkSpeed;
    public float jumpHeight;
    public bool jumping;
    public bool grounded;
    private float previousY;

    void Start()
    {
        walkSpeed = GetComponent<PlayerBehaviour>().playerRuntime.movementSpeed;
        jumping = false;
        grounded = true;
    }

    void Update()
    {
        CheckInput();
    }

    void FixedUpdate()
    {
        Jump();
    }

    void CheckInput()
    {
        PlayerMove();
        MouseTurn();
        //Jump();
    }

    void PlayerMove()
    {
        // forward, backward, stafe
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * walkSpeed;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * walkSpeed;

        // check for walking
        if (Input.GetKey(KeyCode.LeftShift))
        {
            z *= 0.33f;
        }

        //check for jump
        if(jumping)
        {
            x *= 0.33f;
            z *= 0.33f;
        }

        // apply movement
        transform.Translate(x, 0, z);
    }

    void MouseTurn()
    {
        // mouse turn
        var turn = Input.GetAxis("Mouse X") * Time.deltaTime * 150f;
        transform.Rotate(0, turn, 0);
    }

    void Jump()
    {        
        if (grounded)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                grounded = false;
                jumping = true;
            }          
        }

        if (jumping)
        {
            if (transform.position.y > previousY + jumpHeight)
            {
                jumping = false;
                var fallForce = new Vector3(0, -10, 0);
                GetComponent<Rigidbody>().velocity = fallForce;
            }
            if (Input.GetKey(KeyCode.Space))
            {
                var jumpForce = new Vector3(0, 15, 0);
                GetComponent<Rigidbody>().velocity = jumpForce;
            }
            else
            {
                jumping = false;
            }            
        }        
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Level"))
        {
            grounded = true;
            Debug.Log("Landed");
        }
    }
}
