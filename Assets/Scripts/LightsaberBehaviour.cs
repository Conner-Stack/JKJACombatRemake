using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightsaberBehaviour : MonoBehaviour
{
    public Lightsaber lightsaberConfig;
    // Use this for initialization
	void Start ()
	{
	    ConfigureStats(lightsaberConfig);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void ConfigureStats(Lightsaber saberType)
    {
        if (saberType.lightsaberName == "staff")
        {
            //lightsaberConfig.Damage = 
            //lightsaberConfig.swingSpeed = 
        }
        if (saberType.lightsaberName == "sword")
        {
            //lightsaberConfig.Damage = 
            //lightsaberConfig.swingSpeed =
        }
        if (saberType.lightsaberName == "dual")
        {
            //lightsaberConfig.Damage = 
            //lightsaberConfig.swingSpeed =
        }
    }

    void OnTriggerEnter(Collider other)
    {
            if (other.CompareTag("Player"))
            {
                var player = other.GetComponent<PlayerBehaviour>();
                
                player.TakeDamage(lightsaberConfig.Damage);
                player.playerRuntime.isHit = true;
                while (player.playerRuntime.isHit == true)
                {
                    player.TakeSustainedDamage(lightsaberConfig.Damage);
                }
            }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            var player = other.GetComponent<PlayerBehaviour>();
            player.playerRuntime.isHit = false;
        }
    }
    }
