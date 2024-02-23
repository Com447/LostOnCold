using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class TargetInducator : MonoBehaviour
{
    public Transform target;
    public float rotationSpeed;
    public GameObject uitext;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.rotation = Quaternion.Slerp(transform.rotation,Quaternion.LookRotation(target.position-transform.position),rotationSpeed * Time.deltaTime);
    }
    
    void OnTriggerEnter(Collider player)
    {
        if (player.gameObject.tag == "Player")
        {
            uitext.SetActive(true);
            StartCoroutine(WaitForSec5());
            

        }
    }
    
    IEnumerator WaitForSec5()
    {
        yield return new WaitForSeconds(5);
        uitext.SetActive(false);
    }
    
    
    
}
