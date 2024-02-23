using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInWindZone : MonoBehaviour
{
    public bool inWindZone = false;
    public GameObject windZone;

    public Rigidbody rb;

    private void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.tag == "windArea")
        {
            windZone = coll.gameObject;
            inWindZone = true;
        }
    }
    
    private void OnTriggerExit(Collider coll)
    {
        if (coll.gameObject.tag == "windArea")
        {
            windZone = coll.gameObject;
            inWindZone = false;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (inWindZone == true)
        {
            rb.AddForce(windZone.GetComponent<StrongWind>().direction * windZone.GetComponent<StrongWind>().windStrength);
        }
    }
}
