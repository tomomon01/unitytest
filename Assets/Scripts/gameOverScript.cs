using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class gameOverScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
        gameObject.GetComponent<Text>().enabled = false;
	}
	
    public void Lose()
    {
        gameObject.GetComponent<Text>().enabled = true;
    }
}
