using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int maxHealth = 100;
    public int curHealth = 0;
    public bool isAlive;
    void Start()
    {
        curHealth = maxHealth;
        isAlive = true;
    }

    void Update()
    {
        if (!isAlive) return;
        if (curHealth <= 0)
        {
            isAlive = false;
            Debug.Log(this.GetInstanceID() + "isDead!");
        }
    }
}
