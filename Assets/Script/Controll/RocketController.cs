using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketController : MonoBehaviour {

    float Accel = 1000.0f;
    int i = 5;
    Rigidbody rgbody;

	// Use this for initialization
	void Start () {
        rgbody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        //上下へ動かす
        rgbody.AddForce(transform.forward * Input.GetAxisRaw("Vertical") * Accel, ForceMode.Impulse);
        //左右へ動かす
        rgbody.AddForce(transform.right * Input.GetAxisRaw("Horizontal") * Accel, ForceMode.Impulse);

    }

    //オリジナル改造点・当たるたびにボールが増えてパドルが長くなる
    //ゲームとして破綻してるけど……

    void OnCollisionEnter(Collision collision)
    {
        GameObject ball = GameObject.Find("Ball");
        GameObject copied = Object.Instantiate(ball) as GameObject;
        copied.transform.Translate(0, 0, 0);

        i = i + 1;
        this.transform.localScale = new Vector3(i, 1, 1); ;
    }
}
