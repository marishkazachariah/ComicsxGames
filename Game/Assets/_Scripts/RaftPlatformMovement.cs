using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaftPlatformMovement : MonoBehaviour
{
    public float speed = 1f;
    public GameObject player;
    public GameObject platform;

    public Animator moonspiritAnimation;

    public AudioSource dialogueAudio;
    public AudioClip pillDialogue;

    public Transform entranceToMouthTarget;
    public Transform goIntoMouthTarget;

    public Collider raftCollider;
    public Collider platformCollider; 

    private int _direction = 1;

    private Vector3 _playeroffset;
    private Vector3 _originalScale;

    private DialogueImplementation _dialogueimp;
    private MovingObjectManager _moveObjectMgr;

    public void Start()
    {
        _originalScale = new Vector3(1, 1, 1);
        _moveObjectMgr = FindObjectOfType<MovingObjectManager>();
        _dialogueimp = FindObjectOfType<DialogueImplementation>();
        raftCollider.enabled = false;
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Target")
        {
            _dialogueimp.StartThirdNode();
            moonspiritAnimation.SetTrigger("OpenMouth");
            dialogueAudio.clip = pillDialogue;
            dialogueAudio.Play();
        }
    }
    public void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            StartCoroutine("MoveRaftToBody");
            other.transform.parent = transform;
        }
    }
   
    public void OnTriggerExit(Collider collider)
    {
        if (collider.tag == "Player")
        {
            collider.transform.parent = null;
            //StartCoroutine(WaitToTurnOffIsOn());
        }
    }

    public void StartScaleRaft()
    {
        raftCollider.enabled = true;
        platformCollider.enabled = false;
        StartCoroutine(ScaleRaft());
    }

    public void GoToMouth()
    {
        StartCoroutine(MoveRaftToMouth());
    }

    public IEnumerator ScaleRaft()
    {
        yield return new WaitForSeconds(3);
        iTween.ScaleTo(gameObject, iTween.Hash("scale", _originalScale, "time", 3, "easeType", iTween.EaseType.easeOutElastic));
    }

    public IEnumerator MoveRaftToBody()
    {
        yield return new WaitForSeconds(3);
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, entranceToMouthTarget.position, step);
        //iTween.MoveTo(gameObject, iTween.Hash("path", iTweenPath.GetPath("RaftPath"), "time", 15, "easetype", iTween.EaseType.easeInOutSine));
        //iTween.MoveTo(player, iTween.Hash("path", iTweenPath.GetPath("PlayerRaft"), "time", 15, "easetype", iTween.EaseType.easeInOutSine));
    }

    public IEnumerator MoveRaftToMouth()
    {
        yield return new WaitForSeconds(3);
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, goIntoMouthTarget.position, step);
    }
}