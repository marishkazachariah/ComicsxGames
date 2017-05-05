using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObjectManager : MonoBehaviour {

    [Header("Moving Platforms")]
    public GameObject introPlatform;
    //public GameObject raft;

    [Header("Moving Objects")]

    [SerializeField]
    public GameObject ufo, planet1, planet2, planet3, planet4, comet, satellite;

    void Update ()
    {
        satellite.transform.RotateAround(Vector3.zero, Vector3.up, 20 * Time.deltaTime);
        satellite.transform.rotation = Quaternion.identity;

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
