using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaftPlatformMovement : MonoBehaviour
{
    public float speed = 1f;
    public float secondSpeed = 2f;
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
        //raftCollider.enabled = false;
        SetAllCollidersStatus(active: false);
    }


    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Target")
        {
            _dialogueimp.StartThirdNode();
            moonspiritAnimation.SetTrigger("OpenMouth");
            dialogueAudio.clip = pillDialogue;
            dialogueAudio.Play();
        }
        if (other.tag == "finalPath")
            GoToMouth();
    }

    public void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            //StartCoroutine("MoveRaftToBody");
            StartCoroutine(MoveToBody(new Vector3(-12.1f, 262.6f, 278.3f)));
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
        //StartCoroutine(MoveToBody(new Vector3(-21.2f, 272.3f, 335.4f)));

    }

    public IEnumerator ScaleRaft()
    {
        yield return new WaitForSeconds(3);
        platform.SetActive(false);
        iTween.ScaleTo(gameObject, iTween.Hash("scale", _originalScale, "time", 3, "easeType", iTween.EaseType.easeOutElastic));
        yield return new WaitForSeconds(2);
        SetAllCollidersStatus(active: true);
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
        Debug.Log("meow");
        yield return new WaitForSeconds(1);
        iTween.MoveTo(gameObject, new Vector3(-21.2f, 272.3f, 335.4f), 15);
    }

    IEnumerator MoveToBody(Vector3 pos)
    {
        Debug.Log("moving to body");
        yield return new WaitForSeconds(3);
        transform.position = Vector3.MoveTowards(transform.position, pos, speed * Time.deltaTime);
        yield return null;
    }

    public void SetAllCollidersStatus(bool active)
    {
        foreach (Collider c in GetComponents<Collider>())
        {
            c.enabled = active;
        }
    }

}