using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class SoundPlayer : MonoBehaviour
{
    public AudioSource walkSound;
    public AudioSource runSound;
    public AudioSource walkSoundCave;
    public AudioSource runSoundCave;
    private KillPlayer kp;
    
    
    public bool map1;
    public bool map2;
    public bool isRun = false;
    public bool isWalk = false;
    public bool isRunCave = false;
    public bool isWalkCave = false;
    
    
    
    void Start()
    {
        map1 = true;
        map2 = false;
        kp = GameObject.FindGameObjectWithTag("KillPlayer").GetComponent<KillPlayer>();
        
    }

    void Update()
    {

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                isRun = true;
                isWalk = false;
                isRunCave = true;
                isWalkCave = false;
            }
            else
            {
                isRun = false;
                isWalk = true;
                isRunCave = false;
                isWalkCave = true;
            }
        }
        else
        {
            isRun = false;
            isWalk = false;
            isRunCave = false;
            isWalkCave = false;
        }
        
        if (map1 == true)
        {
            if (isWalk == false)
            {
                walkSound.Stop();
            }

            if (isWalk == true)
            {
                Debug.Log("true");
                if (!walkSound.isPlaying)
                {
                    walkSound.Play();
                    Debug.Log("Play");
                }
            }

            if (isRun == false)
            {
                runSound.Stop();
            }

            if (isRun == true)
            {
                Debug.Log("true");
                if (!runSound.isPlaying)
                {
                    runSound.Play();
                    Debug.Log("Play");
                }
            }
        }

        //map2
        if (map2 == true)
        {
            if (isWalkCave == false)
            {
                walkSoundCave.Stop();
            }

            if (isWalkCave == true)
            {
                Debug.Log("true");
                if (!walkSoundCave.isPlaying)
                {
                    walkSoundCave.Play();
                    Debug.Log("Play");
                }
            }

            if (isRunCave == false)
            {
                runSoundCave.Stop();
            }

            if(isRunCave == true)
            {
                Debug.Log("truecave");
                if (!runSoundCave.isPlaying)
                {
                    runSoundCave.Play();
                    Debug.Log("Playcave");
                }
            }
        }

        

    }

}
            
    
    

 
    



