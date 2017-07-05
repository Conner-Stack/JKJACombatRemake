using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightsaberBehaviour : MonoBehaviour
{

    public Lightsaber lightsaberConfig;

    // Use this for initialization
	void Start () {
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
    }
