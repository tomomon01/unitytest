using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class prototype_polayer : MonoBehaviour {

    public float speed = 10;
    float vx = 0;
    float vy = 0;
    //bool leftFlag = false;
    Rigidbody2D rbody;
    public GameObject showObject;
    public GameObject showButton;

    // Use this for initialization
    void Start()
    {
        //SceneManager.LoadScene("");
        rbody = GetComponent<Rigidbody2D>();
        rbody.gravityScale = 0;
        rbody.constraints = RigidbodyConstraints2D.FreezeRotation;
        showObject.SetActive(false);//インスペクタで設定したものを消してる
        showButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //vx = 0;
        //vy = 0;
        vx = Input.GetAxisRaw("Horizontal") * speed;         vy = Input.GetAxisRaw("Vertical") * speed;
        /*
                if (Input.GetKey("right"))
                {
                    vx = speed;
                    //leftFlag = false;
                }
                if (Input.GetKey("left"))
                {
                    vx = -speed;
                    //leftFlag = true;
                }
                if (Input.GetKey("up"))
                {
                    vy = speed;
                }
                if (Input.GetKey("down"))
                {
                    vy = -speed;
                }
        */
        if (OnCollision_StopGame.getEndflag() == true)
        {
            //audioSource = this.GetComponent<AudioSource>();
            //audioSource.Stop();
            AudioListener.pause = true;
            showObject.SetActive(true);//当たったら表示
            showButton.SetActive(true);//当たったら表示
        }
    }

    private void FixedUpdate()
    {
        rbody.velocity = new Vector2(vx, vy);
        //this.GetComponent<SpriteRenderer>().flipX = leftFlag;
    }
}
