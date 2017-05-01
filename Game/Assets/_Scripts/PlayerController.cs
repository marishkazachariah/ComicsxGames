using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public GameObject platform;


    private PlatformManager _movePlatform;
   
	void Start () {

        _movePlatform = FindObjectOfType<PlatformManager>();
	}

	void Update () 
	{
        if (Input.GetKeyDown(KeyCode.T))
        {
            MoveOnPlatform();
        }
    }

	public void OnCollisionEnter (Collision collision)
	{
        if (collision.gameObject.tag == "tool")
        {
            _movePlatform.IntroPlatform();
        }
        //if (collision.gameObject.tag == "raft")
        //{
        //    MoveRaft();
        //    Debug.Log("moving");
        //}
    }

    //public void OnTriggerEnter(Collider collider)
    //{
    //    if (collider.gameObject.tag == "raft")
    //    {
    //        StartCoroutine(MoveRaft());
    //    }
    //}
    

    public void MoveOnPlatform()
    {
        _movePlatform.IntroPlatform();
    }

}
