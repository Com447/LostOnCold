using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delay : MonoBehaviour
{
    public GameObject text;
    public GameObject text1;
    public GameObject text2;
    public GameObject textCon;
    public bool timerStart = false;
    public bool timerStart1 = false;
    public bool timerStart2 = false;
    public bool spaceToCon = false;

    void Start()
    {
        text.SetActive(false);
        text1.SetActive(false);
        text2.SetActive(false);
        StartCoroutine(WaitForSec());
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timerStart == true)
        {
            text.SetActive(true);
            StartCoroutine(WaitForSec1());
        }

        if (timerStart1 == true)
        {
            textCon.SetActive(true);
        }
        
    }
    
   IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(2);
        timerStart = true;
    }
   IEnumerator WaitForSec1()
   {
       yield return new WaitForSeconds(3);
       timerStart1 = true;
   }
   IEnumerator WaitForSec2()
   {
       yield return new WaitForSeconds(2);
       timerStart2 = true;
        
   }
}
