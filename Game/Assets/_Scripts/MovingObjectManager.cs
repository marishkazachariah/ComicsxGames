using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObjectManager : MonoBehaviour {

    [Header("Moving Platforms")]
    public GameObject introPlatform;
    public Animator platformAnim;
    //public GameObject raft;

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
        //_dialogueimp.StartFirstNode();
        IntroPlatform();
        _offset = new Vector3(0, 5, 0);
        _isOn = true;
    }
    private void LateUpdate()
    {
        
    }
    void Update ()
    {
        satellite.transform.RotateAround(Vector3.zero, Vector3.up, 20 * Time.deltaTime);
        satellite.transform.rotation = Quaternion.identity;

        //if (Input.GetKeyDown(KeyCode.O))
        //    platformAnim.SetTrigger("MovePlat1");

    }


    public void IntroPlatform()
    {
        StartCoroutine("FirstSequence");
    }

    public IEnumerator FirstSequence()
    {
        Debug.Log("rawr");
        anim.SetTrigger("StartIntroAnim");
        yield return new WaitForSeconds(3);
        crashingCeiling.Play();
        yield return new WaitForSeconds(8);
        _dialogueimp.StartFirstNode();
        charDialogue.clip = introDialogue[0];
        charDialogue.Play();
        yield return new WaitForSecondsRealtime(35);
        MovePlatformPtOne();
        yield return new WaitForSeconds(35);
        _isOn = true;
        charDialogue.clip = introDialogue[1];
        charDialogue.Play();
    }
    public void MovePlatformPtOne()
    {
        iTween.MoveTo(introPlatform, iTween.Hash("path", iTweenPath.GetPath("FirstIntro"), "time", 30, "movetopath", false, "easetype", iTween.EaseType.easeInQuad, "oncomplete", "MovePlatformPtTwo", "oncompletetarget", this.gameObject));
    }
    public void MovePlatformPtTwo()
    {

        iTween.MoveTo(introPlatform, iTween.Hash("path", iTweenPath.GetPath("SecondIntro"), "time", 10, "easetype", "movetopath", false, iTween.EaseType.easeInCubic, "oncomplete", "MovePlatformPtThree", "oncompletetarget", this.gameObject));
    }

    public void MovePlatformPtThree()
    {
        iTween.MoveTo(introPlatform, iTween.Hash("path", iTweenPath.GetPath("IntroPlatform"), "time", 40, "easetype", iTween.EaseType.linear));
        iTween.MoveTo(ufo, iTween.Hash("path", iTweenPath.GetPath("UfoPath"), "time", 15, "easetype", iTween.EaseType.easeInOutSine));
    }

    public void PlayerTransform()
    {
        if(_isOn == true)
            _player.transform.position = introPlatform.transform.position + _offset;
    }
}
