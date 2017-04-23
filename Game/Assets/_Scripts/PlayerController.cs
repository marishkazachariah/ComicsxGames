using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public GameObject platform;
    public GameObject raft;
    private Vector3 offset;

    private MovePlatform _movePlatform;

	void Start () {
		offset = new Vector3 (0, 1, 0);
        _movePlatform = FindObjectOfType<MovePlatform>();
	}

	void Update () 
	{
        if (Input.GetKeyDown(KeyCode.T))
        {
            MoveOnPlatform();
        }
        if (Input.GetKeyDown(KeyCode.U))
        {
            MoveRaft();
        }
    }

	public void OnCollisionEnter (Collision collision)
	{
        if (collision.gameObject.tag == "tool")
        {
            transform.position = platform.transform.position + offset;
            _movePlatform.StartPlatform();
        }
        if (collision.gameObject.tag == "raft")
        {
            MoveRaft();
            Debug.Log("moving");
        }
    }

    //public void OnTriggerEnter(Collider collider)
    //{
    //    if (collider.gameObject.tag == "raft")
    //    {
    //        MoveRaft();
    //    }
    //}

    public void MoveOnPlatform()
    {
        transform.position = platform.transform.position + offset;
        _movePlatform.StartPlatform();
    }

    public void MoveRaft()
    {
        iTween.MoveTo(raft, iTween.Hash("path", iTweenPath.GetPath("RaftPath"), "time", 5, "easetype", iTween.EaseType.linear));
    }
}
