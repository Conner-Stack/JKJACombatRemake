using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementBehaviour : MonoBehaviour
{
    /*
    private float previousY;
    private bool jumping = false;
    */         
	
	void Update ()
    {
        PlayerMove();
	}

    void PlayerMove()
    {
        // forward, backward, stafe
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * 10f;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * 10f;        
        transform.Translate(x, 0, z);

        // mouse turn
        var turn = Input.GetAxis("Mouse X") * Time.deltaTime * 150f;
        transform.Rotate(0, turn, 0);       
    }
}

/*
       // jump
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
       */
