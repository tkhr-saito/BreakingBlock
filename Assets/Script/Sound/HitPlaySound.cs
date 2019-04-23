﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitPlaySound : MonoBehaviour {

    public AudioClip sound;
    void OnCollisionEnter(Collision collision)
    {
        AudioSource.PlayClipAtPoint(sound, collision.transform.position);    
    }
}
