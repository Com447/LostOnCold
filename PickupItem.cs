using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupItem : MonoBehaviour
{
    public GameObject grave;
    public GameObject item;
    public AudioSource pickup;
    public Transform targetTransForm;
    public GameObject fade;
    public Credit cd;
    
    public GameObject uitextmassage;
    public GameObject uiObjectTextCon;
    public GameObject goHomeMassage;
    public bool timerStart = false;

    void Start()
    {
       grave.SetActive(false); 
       uiObjectTextCon.SetActive(false);
       cd.credit.SetActive(false);
       cd = cd.GetComponent<Credit>();
    }
    void OnTriggerEnter(Collider plyr)
    {
        if (plyr.gameObject.tag == "Player")
        {
           grave.SetActive(true);
           pickup.Play();
           plyr.transform.position = targetTransForm.position;
           fade.SetActive(true);
           uitextmassage.SetActive(true);
           goHomeMassage.SetActive(true);
           cd.credit.gameObject.SetActive(true);
           StartCoroutine(WaitForSec());
        }
    }

    void Update()
    {
        if (timerStart == true)
        {
            uiObjectTextCon.SetActive(true);
            if (Input.GetKey(KeyCode.Space))
            {
                Destroy(uiObjectTextCon);
                Destroy(uitextmassage);  
            }
        }
    }
    
    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(4);
        Debug.Log("Time");
        timerStart = true;
    }
    
}
