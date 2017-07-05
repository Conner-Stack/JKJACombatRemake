using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour, IDamagable
{
    public Player playerConfig;
    public Player playerRuntime;


    // Use this for initialization
    void Start ()
    {
        playerConfig.hp = 100;
        playerRuntime = playerConfig;
	}
	
	// Update is called once per frame
	void Update ()
    {		

	}

    public void TakeDamage(int Damage)
    {
        playerRuntime.hp -= Damage;
    }
    //will add a type of ability in the arguments and remove the damage argument
    public void TakeAbilityDamage(int Damage)
    {
        playerRuntime.hp -= Damage;
    }

    public void TakeSustainedDamage(int Damage)
    {
        playerRuntime.hp -= Damage / 10;
    }
}
