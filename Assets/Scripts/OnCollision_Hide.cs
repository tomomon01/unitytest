using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollision_Hide : MonoBehaviour {

    public string targetObjectName;
    public string hideObjectName;
	// Use this for initialization
	void Start () {
        Debug.Log("start");
	}

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.name);
        Debug.Log(targetObjectName);
        if (collision.gameObject.name == targetObjectName) {
            Debug.Log("enter");
            GameObject hideObject = GameObject.Find(hideObjectName);
            hideObject.SetActive(false);
        }
    }
}
