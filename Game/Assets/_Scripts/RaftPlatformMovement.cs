using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaftPlatformMovement : MonoBehaviour
{
    public float speed = 10;
    private int direction = 1;

    void Update()
    {
        //transform.Translate(Vector3.forward * speed * direction * Time.deltaTime);

    }

    void OnTriggerEnter(Collider other)
    {
        //if (other.tag == "Target")
        //{
        //    if (direction == 1)
        //        direction = -1;
        //    else
        //        direction = 1;
        //}

        if (other.tag == "Player")
        {
            other.transform.parent = transform;
            //transform.Translate(Vector3.forward * speed * direction * Time.deltaTime);

            iTween.MoveTo(gameObject, iTween.Hash("path", iTweenPath.GetPath("RaftPath"), "time", 5, "easetype", iTween.EaseType.linear));

        }
    }

    //private void OnTriggerExit(Collider other)
    //{
    //    if (other.tag == "Player")
    //    {
    //        other.transform.parent = null;
    //    }
    //}
}