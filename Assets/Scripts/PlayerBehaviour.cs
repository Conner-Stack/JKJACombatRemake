using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    public Player playerConfig;
    public Player playerRuntime;

    // Use this for initialization
    void Start ()
    {
        playerRuntime = playerConfig;
	}
	
	// Update is called once per frame
	void Update ()
    {		

	}
}
