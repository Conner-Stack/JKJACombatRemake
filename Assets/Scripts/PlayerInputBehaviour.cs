using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputBehaviour : MonoBehaviour
{
    public float walkSpeed = 0;
    private bool jumping;
    private float previousY;

    void Start()
    {
        walkSpeed = GetComponent<PlayerBehaviour>().playerRuntime.movementSpeed;
    }

    void Update()
    {
        CheckInput();
    }

    void CheckInput()
    {
        PlayerMove();
        MouseTurn();
        Jump();
    }

    void PlayerMove()
    {
        // forward, backward, stafe
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * walkSpeed;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * walkSpeed;
        transform.Translate(x, 0, z);
        var force = new Vector3(x, 0, z);
    }

    void MouseTurn()
    {
        // mouse turn
        var turn = Input.GetAxis("Mouse X") * Time.deltaTime * 150f;
        transform.Rotate(0, turn, 0);
    }

    void Jump()
    {
        if (jumping == false)
        {
            jumping = true;
            if (Input.GetKeyDown(KeyCode.Space))
            {
                previousY = transform.position.y;
            }
        }

        if (Input.GetKey(KeyCode.Space))
        {
            previousY = transform.position.y;
            var jumpforce = previousY + Time.deltaTime;
            transform.Translate(0, jumpforce, 0);
        }
        else
        {
            jumping = false;
        }
    }
}
