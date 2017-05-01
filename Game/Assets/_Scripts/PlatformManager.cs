using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformManager : MonoBehaviour {

    [Header("Moving Platforms")]
    public GameObject introPlatform;
    //public GameObject raft;

    [Header("Other Objects")]
    public GameObject ufo;

    void Update ()
    {

        //if (Input.GetKeyDown(KeyCode.U))
        //{
        
        //}

    }

  
    public void IntroPlatform()
    {
        iTween.MoveTo(introPlatform, iTween.Hash("path", iTweenPath.GetPath("IntroPlatform"), "time", 15, "easetype", iTween.EaseType.linear));
        iTween.MoveTo(ufo, iTween.Hash("path", iTweenPath.GetPath("UfoPath"), "time", 5, "easetype", iTween.EaseType.easeInOutSine));

    }

    
}
