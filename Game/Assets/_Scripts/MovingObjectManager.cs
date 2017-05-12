using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObjectManager : MonoBehaviour {

    [Header("Moving Platforms")]
    public GameObject introPlatform;

    [Header("Moving Objects")]

    [SerializeField]
    public GameObject ufo, planet1, planet2, planet3, planet4, comet, satellite;

    [Header("Audio")]
    public AudioSource crashingCeiling;
    public AudioSource charDialogue;
    public AudioClip[] introDialogue;
    //public AudioClip introDialoguePt2;

    public Animator anim;
    [SerializeField]
    [Header("Player")]
    private GameObject _player;
    private PlayerController _playerCtrl;
    private DialogueImplementation _dialogueimp;

    private Vector3 _offset;

    [SerializeField]
    private bool _isOn = false;

    private void Start()
    {
        _player = GameObject.Find("Player");
        _dialogueimp = FindObjectOfType<DialogueImplementation>();
        _playerCtrl = FindObjectOfType<PlayerController>();
        _offset = new Vector3(0, 5, 0);
        _isOn = false;
        IntroPlatform();
    }

    private void LateUpdate()
    {
        if (_isOn == true)
            _player.transform.position = introPlatform.transform.position + _offset;

    }

    void Update ()
    {
        satellite.transform.RotateAround(Vector3.zero, Vector3.up, 20 * Time.deltaTime);
        satellite.transform.rotation = Quaternion.identity;
        planet1.transform.Rotate(0, 1f, 0);
        planet2.transform.Rotate(0, 1f, 0, Space.World);
        planet3.transform.Rotate(0, 1f, 0, Space.World);
        planet4.transform.Rotate(0, 1f, 0, Space.World);

        //if (Input.GetKeyDown(KeyCode.O))
        //    platformAnim.SetTrigger("MovePlat1");

    }

    public void IntroPlatform()
    {
        StartCoroutine("FirstSequence");
    }

    public IEnumerator FirstSequence()
    {
        anim.SetTrigger("StartIntroAnim");
        yield return new WaitForSeconds(3);
        crashingCeiling.Play();
        yield return new WaitForSeconds(8);
        _dialogueimp.StartFirstNode();
        charDialogue.clip = introDialogue[0];
        charDialogue.Play();
        yield return new WaitForSecondsRealtime(28);
        _isOn = true;
        MovePlatformPtOne();
        yield return new WaitForSeconds(41);
        charDialogue.clip = introDialogue[1];
        charDialogue.Play();
        _dialogueimp.StartSecondNode();
        yield return new WaitForSeconds(35);
        _isOn = false;
    }

    public void MovePlatformPtOne()
    {
        iTween.MoveTo(introPlatform, iTween.Hash("path", iTweenPath.GetPath("FirstIntro"), "time", 29, "easetype", iTween.EaseType.easeInCubic, "oncomplete", "MovePlatformPtTwo", "oncompletetarget", this.gameObject));
    }

    public void MovePlatformPtTwo()
    {
        iTween.MoveTo(introPlatform, iTween.Hash("path", iTweenPath.GetPath("SecondIntro"), "time", 15, "movetopath", false, "easetype", iTween.EaseType.easeInOutCubic, "oncomplete", "MovePlatformPtThree", "oncompletetarget", this.gameObject));
    }

    public void MovePlatformPtThree()
    {
        iTween.MoveTo(introPlatform, iTween.Hash("path", iTweenPath.GetPath("IntroPlatform"), "time", 30, "movetopath", false, "easetype", iTween.EaseType.linear));
        iTween.MoveTo(ufo, iTween.Hash("path", iTweenPath.GetPath("UfoPath"), "time", 15, "easetype", iTween.EaseType.easeInOutSine));
        iTween.MoveTo(comet, iTween.Hash("path", iTweenPath.GetPath("CometPath"), "time", 15, "easetype", iTween.EaseType.easeInOutSine));
    }

}
