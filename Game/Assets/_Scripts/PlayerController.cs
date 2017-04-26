﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public GameObject platform;
    public GameObject raft;

    private Vector3 offset;
    private Rigidbody _rb;

    private MovePlatform _movePlatform;
   
	void Start () {
		offset = new Vector3 (0, 1, 0);
        _rb = GetComponent<Rigidbody>();

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
            _movePlatform.IntroPlatform();
        }
        //if (collision.gameObject.tag == "raft")
        //{
        //    MoveRaft();
        //    Debug.Log("moving");
        //}
    }

    public void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "raft")
        {
            StartCoroutine(MoveRaft());
        }
    }
    

    public void MoveOnPlatform()
    {
        _movePlatform.IntroPlatform();
    }

    public IEnumerator MoveRaft()
    {
        yield return new WaitForSeconds(5);
        iTween.MoveTo(raft, iTween.Hash("path", iTweenPath.GetPath("RaftPath"), "time", 5, "easetype", iTween.EaseType.linear));
        transform.position = raft.transform.position + offset;
        _rb.MovePosition(transform.position + transform.forward * Time.deltaTime);

        // iTween.MoveTo(gameObject, iTween.Hash("path", iTweenPath.GetPath("playerOnPlatform"), "time", 5, "easetype", iTween.EaseType.linear));

    }
}
