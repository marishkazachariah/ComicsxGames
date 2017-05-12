using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFade : MonoBehaviour {

	// Use this for initialization
	void Start () {
        iTween.FadeTo(gameObject, 255, 1f);

    }

    // Update is called once per frame
    void Update () {
    }
}
