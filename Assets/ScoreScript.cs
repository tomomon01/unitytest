using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour {

    private int score = 0;
	// Use this for initialization
	void Start () {
        GetComponent<Text>().text = "SCORE: " + score.ToString();
	}
	
    public void ScoreUp(int point)
    {
        score += point;
        GetComponent<Text>().text = "SCORE: " + score.ToString();
    }
}
