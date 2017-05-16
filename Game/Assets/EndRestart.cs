using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EndRestart : MonoBehaviour {

	// Use this for initialization
	void Start () {
        StartCoroutine(Reset());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public IEnumerator Reset()
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene("MainMenu");
    }
}
