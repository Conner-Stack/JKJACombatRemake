using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "Lightsaber Stats")]
public class Lightsaber : MonoBehaviour {

    public int Damage;
    public float swingSpeed;
    public bool holster;
    public enum saberType
    {
        single = 1,
        dual = 2,
        staff = 3
    }
}
