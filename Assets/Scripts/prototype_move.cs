using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prototype_move : MonoBehaviour {

    public GameObject Prefab;
    public GameObject movingObj;
    public float second;
    public float vecY;
    public GameObject showObject;
    //AudioSource audioSource;

    void Start()
    {
        StartCoroutine(MoveMap());
        StartCoroutine(SetTree());
    }

    IEnumerator SetTree()
    {
        while (true)
        {
            Vector3 pos = new Vector3(11, vecY, 1);//4.4f
            GameObject tree = Instantiate(Prefab, pos, transform.rotation) as GameObject;
            tree.transform.parent = movingObj.transform;
            yield return new WaitForSeconds(second);//0.26f
        }
    }

    IEnumerator MoveMap()
    {
        while (true)
        {
            Vector3 pos = movingObj.transform.position;
            pos.x -= 4 * Time.deltaTime;
            movingObj.transform.position = pos;
            yield return 0;
        }
    }
    private void Update()
    {
        /*
        if (OnCollision_StopGame.getEndflag() == true)
        {
            //audioSource = this.GetComponent<AudioSource>();
            //audioSource.Stop();
            AudioListener.pause = true;
        }
        */
    }
}
