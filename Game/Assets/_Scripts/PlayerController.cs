using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public GameObject platform;


    private MovingObjectManager _moveObject;
   
	void Start () {

        _moveObject = FindObjectOfType<MovingObjectManager>();
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
            _moveObject.IntroPlatform();
        }
       
    }

    public void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "raft")
        {
            transform.parent = collision.transform;
        }
        else
        {
            transform.parent = null;
        }
    }

        public void MoveOnPlatform()
    {
        _moveObject.IntroPlatform();
    }

}
