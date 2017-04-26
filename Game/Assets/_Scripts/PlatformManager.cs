using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformManager : MonoBehaviour {

    [Header("Moving Platforms")]
    public GameObject introPlatform;
    public GameObject raft;

    private Vector3 offset;
  
    void Start ()
    {
    }

    void Update ()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            IntroPlatform();
        }
        if (Input.GetKeyDown(KeyCode.U))
        {
            RaftToBody();
        }

    }

    public void IntroPlatform()
    {
        iTween.MoveTo(introPlatform, iTween.Hash("path", iTweenPath.GetPath("IntroPlatform"), "time", 15, "easetype", iTween.EaseType.linear));
    }

    public void RaftToBody()
    {
        iTween.MoveTo(raft, iTween.Hash("path", iTweenPath.GetPath("RaftPath"), "time", 5, "easetype", iTween.EaseType.linear));
    }

}
