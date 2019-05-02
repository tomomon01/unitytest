using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Forever_MoveH_OnCollision_Flip : MonoBehaviour {
    public float speed = 1;
    // Use this for initialization
    Rigidbody2D rbody;
	void Start () {
        rbody = GetComponent<Rigidbody2D>();
        rbody.gravityScale = 0;
        rbody.constraints = RigidbodyConstraints2D.FreezeRotation;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        rbody.velocity = new Vector2(speed, 0);
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        speed = -speed;
        this.GetComponent<SpriteRenderer>().flipX = (speed < 0);
    }
}
