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

    private GameObject player;

    private void Start()
    {
        player = GameObject.Find("Player");
    }

    void Update ()
    {
        satellite.transform.RotateAround(Vector3.zero, Vector3.up, 20 * Time.deltaTime);
        satellite.transform.rotation = Quaternion.identity;
    }


    public void IntroPlatform()
    {
        iTween.MoveTo(introPlatform, iTween.Hash("path", iTweenPath.GetPath("IntroPlatform"), "time", 60, "easetype", iTween.EaseType.linear));

        iTween.MoveTo(ufo, iTween.Hash("path", iTweenPath.GetPath("UfoPath"), "time", 15, "easetype", iTween.EaseType.easeInOutSine));
    }
}
