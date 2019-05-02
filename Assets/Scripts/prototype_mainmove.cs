using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prototype_mainmove : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.anyKey)
        {
            Application.LoadLevel("prototype");
        }
    }
}
