using System.Collections;
using UnityEngine;

public class Enemy : Token {

    public static int Count = 0;
	// 開始
	void Start ()
    {
        Count++;

        SetSize(SpriteWidth / 2, SpriteHeight / 2);

        float dir = Random.Range(0, 359);
        //速さは2
        float spd = 2;
        SetVelocity(dir, spd);
	}

    private void Update()
    {
        Vector2 min = GetWorldMin();
        Vector2 max = GetWorldMax();
        if (X < min.x || max.x < X) {
            VX *= -1;
            ClampScreen();
        }
        if (Y < min.y || max.y < Y)
        {
            VY *= -1;
            ClampScreen();
        }
    }

    public void OnMouseDown()
    {
        Count--;
        for (int i = 0; i < 32; i++)
        {
            Particle.Add(X, Y);
        }
        DestroyObj();
    }
}
