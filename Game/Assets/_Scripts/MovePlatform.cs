using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlatform : MonoBehaviour {

	public GameObject player;
	private Vector3 offset; 

	void Start ()
    {
    }

    void Update ()
    {

	}

	public void StartPlatform()
    {
        iTween.MoveTo(gameObject, iTween.Hash("path", iTweenPath.GetPath("IntroPlatform"), "time", 15, "easetype", iTween.EaseType.linear));
    }

    public void MoveIntoBody()
    {
        iTween.MoveTo(gameObject, iTween.Hash("path", iTweenPath.GetPath("IntoBody"), "time", 15, "easetype", iTween.EaseType.linear));
    }
}
