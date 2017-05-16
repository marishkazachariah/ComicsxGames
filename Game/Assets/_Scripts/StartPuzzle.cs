using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class StartPuzzle : MonoBehaviour {


    public Animator caveMovement;
    public DialogueImplementation moonspiritDialogue;
    public FeedMouth fadeFromBlack;
    public AudioSource spiritTalking;

	void Start ()
    {
        //caveMovement.SetTrigger("ToIdle");
        spiritTalking.Play();
        moonspiritDialogue.StartForthNode();
        StartCoroutine(FadingToWhite());
    }


    // Update is called once per frame
    void Update () {
		
	}

    public IEnumerator FadingFromBlack()
    {
        yield return new WaitForSeconds(1);
        fadeFromBlack.FadeFromBlack();
    }

    public IEnumerator FadingToWhite()
    {
        yield return new WaitForSeconds(33);
        FadeToWhite();
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("Ending");
    }
    private float _fadeDuration = 1f;

    public void FadeToWhite()
    {
        //set start color
        SteamVR_Fade.Start(Color.clear, 0f);
        //set and start fade to
        SteamVR_Fade.Start(Color.white, _fadeDuration);
    }
}
