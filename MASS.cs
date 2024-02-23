using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MASS : MonoBehaviour
{
    
        public float gravitationalConstant = 9.81f;
        public float dragCoefficient = 0.1f;
        public bool down = false;

        private Rigidbody rb;

        void Start()
        {
            rb = GetComponent<Rigidbody>();
        }

        void FixedUpdate()
        {
            if (down == true)
            {
                Vector3 gravityForce = new Vector3(0, -gravitationalConstant * rb.mass, 0);
                Vector3 airResistanceForce = -dragCoefficient * rb.velocity;
                Vector3 totalForce = gravityForce + airResistanceForce;
                rb.AddForce(totalForce, ForceMode.Acceleration);
            }
            
        }
}
