using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FeedMouth : MonoBehaviour {

    public int fed = 0;
    public Camera mainCamera;
    public Animator moonspiritAnimation;

    private RaftPlatformMovement _raftController;

    private void Start()
    {
        _raftController = FindObjectOfType<RaftPlatformMovement>();
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "pill")
        {
            fed += 1;
        }
    }

    public void CheckPillAmount()
    {
        if(fed == 3)
        {
            moonspiritAnimation.SetTrigger("GoToCave");
            //trigger openmouth animation + camera fade + loadscene!!
            StartCoroutine(GoToNextScene());
        }
    }

    public IEnumerator GoToNextScene()
    {
        yield return new WaitForSeconds(2);
        _raftController.GoToMouth();
        yield return new WaitForSeconds(2);
        iTween.CameraFadeTo(1.0f, 1.0f);
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("InsideMoonSpirit");
    }
}
