using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketController : MonoBehaviour {

    float Accel = 1000.0f;
    Rigidbody rgbody;

	// Use this for initialization
	void Start () {
        rgbody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        rgbody.AddForce(transform.right * Input.GetAxisRaw("Horizontal") * Accel, ForceMode.Impulse);
	}
}
