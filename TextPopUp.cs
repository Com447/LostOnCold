using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextPopUp : MonoBehaviour
{
    [SerializeField] public GameObject uiObjectText;
    [SerializeField] public GameObject uiObjectTextCon;

    [HideInInspector]public bool timerStart = false;

    void Start()
    {
        uiObjectText.SetActive(false);
        uiObjectTextCon.SetActive(false);
    }

    void OnTriggerEnter(Collider player)
    {
        if (player.gameObject.tag == "Player")
        {
            uiObjectText.SetActive(true);
            StartCoroutine(WaitForSec());
        }
    }

    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(4);
        timerStart = true;
    }
    
    IEnumerator WaitforSecc() 
    {
        yield return new WaitForSeconds(4);
        uiObjectTextCon.SetActive(true);
    }

    void Update()
    {
        if (timerStart == true)
        {
            uiObjectTextCon.SetActive(true);
            if (Input.GetKey(KeyCode.Space))
            {
                Destroy(uiObjectTextCon);
                Destroy(uiObjectText);  
            }
        }
    }
    
    
}
