using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour {
    AudioSource[] sounds;

    private void Start()
    {
        sounds = GetComponents<AudioSource>();
    }

    // Update is called once per frame
    void Update () {
		if (Input.GetKeyDown("joystick button 0") || Input.GetKeyDown("left shift")) {
            sounds[0].Play();
        }
	}
}
