using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
    public class EndingCredits : MonoBehaviour {

    public DialogueImplementation dialogueImplementation;

    void Start ()
    {
        dialogueImplementation.StartFifthNode();
		
	}


    void Update ()
    {
		if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("MainMenu");

        }
    }
}
