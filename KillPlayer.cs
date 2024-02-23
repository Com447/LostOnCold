using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillPlayer : MonoBehaviour
{
    private PlayerCode pc;
    public AudioSource playerDeadsound;
    public AudioSource rockToGround;
    
    public bool alreadyGround = false;
    public bool playerDead = false;

    public void Start()
    {
        pc = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerCode>();
    }

    public void OnCollisionEnter(Collision plry)
    {
        if (plry.gameObject.tag == ("Player"))
        {
            pc.playerIsDead = true;
           // playerDead = true;
            playerDeadsound.Play();
        }
        else if (alreadyGround == false)
        {
            rockToGround.Play();
            alreadyGround = true;
        }
    }
}
