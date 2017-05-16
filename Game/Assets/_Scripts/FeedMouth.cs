using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Reflection;
using Valve.VR;

public class FeedMouth : MonoBehaviour {

    public int fed = 0;
    public Camera mainCamera;
    public Animator moonspiritAnimation;
    public AudioSource moonspiritWail;
    private RaftPlatformMovement _raftController;

    private void Start()
    {
        _raftController = FindObjectOfType<RaftPlatformMovement>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("MainMenu");
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "pill")
        {
            fed ++;
            moonspiritWail.Play();
            if (fed > 2)
            {
                moonspiritAnimation.SetTrigger("GoToCave");
                //trigger openmouth animation + camera fade + loadscene!!
                StartCoroutine(GoToNextScene());
            }
        }
    }

    public IEnumerator GoToNextScene()
    {
        yield return new WaitForSeconds(1);
        _raftController.GoToMouth();
        yield return new WaitForSeconds(2);
        FadeToBlack();
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("InsideMoonSpirit");
    }

    private float _fadeDuration = 1f;

    public void FadeToBlack()
    {
        //set start color
        SteamVR_Fade.Start(Color.clear, 0f);
        //set and start fade to
        SteamVR_Fade.Start(Color.black, _fadeDuration);
    }

    public void FadeFromBlack()
    {
        //set start color
        SteamVR_Fade.Start(Color.black, 0f);
        //set and start fade to
        SteamVR_Fade.Start(Color.clear, _fadeDuration);
    }
}
