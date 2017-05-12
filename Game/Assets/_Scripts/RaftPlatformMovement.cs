using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaftPlatformMovement : MonoBehaviour
{
    public float speed = 1f;
    public GameObject player;
    public GameObject platform;

    public Transform target;

    public Collider raftCollider;
    public Collider platformCollider; 

    private int _direction = 1;

    private Vector3 _playeroffset;
    private Vector3 _originalScale;

    private MovingObjectManager _moveObjectMgr;

    public void Start()
    {
        _originalScale = new Vector3(1, 1, 1);
        _moveObjectMgr = FindObjectOfType<MovingObjectManager>();
        raftCollider.enabled = false;
    }

    private void LateUpdate()
    {
        //if (_onRaft == true)
        //    player.transform.position = gameObject.transform.position + _playeroffset;
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

    public IEnumerator ScaleRaft()
    {
        yield return new WaitForSeconds(3);
        iTween.ScaleTo(gameObject, iTween.Hash("scale", _originalScale, "time", 3, "easeType", iTween.EaseType.easeOutElastic));
    }

    public IEnumerator MoveRaftToBody()
    {
        yield return new WaitForSeconds(3);
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);
        //iTween.MoveTo(gameObject, iTween.Hash("path", iTweenPath.GetPath("RaftPath"), "time", 15, "easetype", iTween.EaseType.easeInOutSine));
        //iTween.MoveTo(player, iTween.Hash("path", iTweenPath.GetPath("PlayerRaft"), "time", 15, "easetype", iTween.EaseType.easeInOutSine));

    }
}