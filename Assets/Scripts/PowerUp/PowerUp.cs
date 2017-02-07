﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PowerUp : MonoBehaviour
{
    public float timer { get; set; }
    public bool isUsed { get; set; }
    public PlayerController player;

    void Start()
    {
        isUsed = false;
    }

    public void Update()
    {
        if (isUsed)
        {
            GetComponent<SpriteRenderer>().enabled = false;
            GetComponent<Collider2D>().enabled = false;
            if (timer <= 0)
            {
                this.Reset();
                Destroy(this.gameObject);
                Debug.Log("destroyed");
            }
            else
            {
                timer -= Time.deltaTime;
            }
        }
        Debug.Log(timer);
    }

    public abstract void Reset();


}