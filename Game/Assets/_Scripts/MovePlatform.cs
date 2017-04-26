using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlatform : MonoBehaviour {

    [Header("Moving Platforms")]
    public GameObject introPlatform;
    public GameObject raft;

    private Vector3 offset;
  
    void Start ()
    {
    }

    void Update ()
    {

	}

    void OnTriggerEnter(Collider other)
    {
   
        if (other.tag == "Player")
        {
            other.transform.parent = transform;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            other.transform.parent = null;
        }
    }

    public void IntroPlatform()
    {
        iTween.MoveTo(gameObject, iTween.Hash("path", iTweenPath.GetPath("IntroPlatform"), "time", 15, "easetype", iTween.EaseType.linear));
    }

    public void RaftToBody()
    {
        iTween.MoveTo(raft, iTween.Hash("path", iTweenPath.GetPath("RaftPath"), "time", 5, "easetype", iTween.EaseType.linear));
    }

}
