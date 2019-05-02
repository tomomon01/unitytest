using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollision_Show : MonoBehaviour {

    public string targetObjectName;
    //public GameObject showObject;
    public string showObjectName;
    public string showButtonName;

    GameObject showObject;
    GameObject showButton;

    // Use this for initialization
    void Start () {
/*
        showObject = GameObject.Find(showObjectName);
        showObject.SetActive(false);//インスペクタで設定したものを消してる
        showButton = GameObject.Find(showButtonName);
        showButton.SetActive(false);
*/
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == targetObjectName) {
            //showObject.SetActive(true);//当たったら表示
            //showButton.SetActive(true);//当たったら表示

        }
    }
}
