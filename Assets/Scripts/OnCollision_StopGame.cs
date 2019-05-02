using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollision_StopGame : MonoBehaviour {

    public string targetObjectName;
    public static bool endFlag = false;

	// Use this for initialization
	void Start () {
        Time.timeScale = 1;
        endFlag = false;
        AudioListener.pause = false;

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == targetObjectName) {
            Time.timeScale = 0;
            endFlag = true;
        }
    }

    public static bool getEndflag()
    {
        return endFlag;
    }

}
