using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {
    float speed = 20.0f;
    Rigidbody rgbody;
	// Use this for initialization
	void Start () {
        rgbody = GetComponent<Rigidbody>();
        rgbody.AddForce((transform.forward + transform.right) * speed, ForceMode.VelocityChange);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
