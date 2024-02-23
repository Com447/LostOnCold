using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RockFall : MonoBehaviour
{
    public Rigidbody rockRb;
    public AudioSource rockFall;
    public MASS ms;

    void Start()
    {
        ms = ms.GetComponent<MASS>();
    }


    private void OnTriggerEnter(Collider Player)
    {
        if (Player.gameObject.tag == "Player")
        {
            rockRb.useGravity = true;
            rockFall.Play();
            ms.down = true;
        }
    }
}
