using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KinematicChange : MonoBehaviour {

    // Use this for initialization
    private Rigidbody rb;
    private Rigidbody ob;
    void Start () {
        rb = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.GetComponent<Rigidbody>())
        {
            ob = col.gameObject.GetComponent<Rigidbody>();
        }
        if (ob.isKinematic == false)
        {
            rb.isKinematic = false;
        }
    }
}
