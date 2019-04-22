using System.Collections;
using UnityEngine;

public class buttonScript : MonoBehaviour {

    public void ButtonPush()
    {
        Application.LoadLevel("Piyo");
    }

    public void Update()
    {
        if (Input.GetKeyDown("joystick button 2"))
        {
            Application.LoadLevel("Piyo");
        }
    }
}
