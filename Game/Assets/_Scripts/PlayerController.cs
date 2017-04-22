using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public GameObject platform;

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
    }

	public void OnCollisionEnter (Collision collision)
	{
        if (collision.gameObject.tag == "tool")
        {
            transform.position = platform.transform.position + offset;
            _movePlatform.StartPlatform();
        }
	}

    public void MoveOnPlatform()
    {
        transform.position = platform.transform.position + offset;
        _movePlatform.StartPlatform();
    }
}
