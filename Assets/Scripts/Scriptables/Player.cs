using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "Player Stats")]
public class Player : ScriptableObject {
    public string playerName;
    public int hp;
    public float movementSpeed;
    public string playerClass;
    public enum stance
    {
        light = 1,
        medium = 2,
        heavy = 3
    }
}
