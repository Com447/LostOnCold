using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkMap2 : MonoBehaviour
{
    public GameObject arrow;
    public GameObject brizzard;
    public GameObject caveSound;
    public GameObject block;
    public AudioSource brizzard1;
    
    
    private SoundPlayer sp;
    
     
    void Start()
    {
        sp = GameObject.FindGameObjectWithTag("Player").GetComponent<SoundPlayer>();
    }
    
    void OnTriggerEnter(Collider plyr)
    {
        if (plyr.gameObject.tag == "Player")
        {
            sp.map2 = true;
            sp.map1 = false;
            Debug.Log("Map2");
            sp.walkSound.Stop();
            sp.runSound.Stop();
            brizzard1.Stop();
            Destroy(arrow);
            caveSound.SetActive(true);
            brizzard.SetActive(false);
            block.SetActive(true);
            
        }
    }
}
