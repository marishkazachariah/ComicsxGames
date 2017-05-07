using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObjectManager : MonoBehaviour {

    [Header("Moving Platforms")]
    public GameObject introPlatform;
    //public GameObject raft;

    [Header("Moving Objects")]

    [SerializeField]
    public GameObject ufo, planet1, planet2, planet3, planet4, comet, satellite;

    [Header("Audio")]
    public AudioSource introDialogue;
    public AudioSource crashingCeiling;

    [SerializeField]
    [Header("Player")]
    private Animator anim;

    private GameObject _player;

    private DialogueImplementation _dialogueimp;

    private void Start()
    {
        _player = GameObject.Find("Player");
        _dialogueimp = FindObjectOfType<DialogueImplementation>();
        //_dialogueimp.StartFirstNode();
    }

    void Update ()
    {
        satellite.transform.RotateAround(Vector3.zero, Vector3.up, 20 * Time.deltaTime);
        satellite.transform.rotation = Quaternion.identity;

        if (Input.GetKeyDown(KeyCode.O))
            anim.SetTrigger("StartIntroAnim");
    }


    public void IntroPlatform()
    {
        StartCoroutine("FirstSequence");
    }

    public IEnumerator FirstSequence()
    {
        anim.SetTrigger("StartIntroAnim");
        yield return new WaitForSeconds(9);
        crashingCeiling.Play();
        yield return new WaitForSeconds(3);
        _dialogueimp.StartFirstNode();
        introDialogue.Play();
        yield return new WaitForSecondsRealtime(30);

        iTween.MoveTo(introPlatform, iTween.Hash("path", iTweenPath.GetPath("FirstIntro"), "time", 30, "easetype", iTween.EaseType.easeInExpo));
        yield return new WaitForSeconds(15f);
        MovePlatformPtTwo();
    }

    public void MovePlatformPtTwo()
    {
        iTween.MoveTo(introPlatform, iTween.Hash("path", iTweenPath.GetPath("IntroPlatform"), "time", 60, "easetype", iTween.EaseType.linear));
        iTween.MoveTo(ufo, iTween.Hash("path", iTweenPath.GetPath("UfoPath"), "time", 15, "easetype", iTween.EaseType.easeInOutSine));
    }
}
