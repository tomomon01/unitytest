using UnityEngine;
using System.Collections;

public class playerScript : MonoBehaviour
{
    public GameObject Score;
    private Rigidbody2D rb2D;
    private float jumpForce = 10.0f;
    public GameObject GameOverGUI;
    private bool gameover = false;
    private Animator anim;

    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        anim = GetComponent("Animator") as Animator;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown("joystick button 2"))
        {
            Jump();
        }
        if (gameover == true)
        {
            anim.SetBool("gameover", true);
            GameOverGUI.SendMessage("Lose");
        }
    }

    void Jump()
    {
        rb2D.velocity = new Vector2(rb2D.velocity.x, jumpForce);
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        Score.SendMessage("ScoreUp", 1);
        Destroy(col.gameObject);
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        StartCoroutine(GameOver());
    }

    IEnumerator GameOver()
    {
        //gameover = true;
        //yield return new WaitForSeconds(1f);
        while (!Input.GetMouseButton(0)) { yield return 0; }
        //Application.LoadLevel("piyotitle");
    }
}
