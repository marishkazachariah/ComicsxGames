using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaftPlatformMovement : MonoBehaviour
{
    public float speed = 20f;
    private int direction = 1;
    public GameObject player;
    public Transform target;

    private Vector3 raftPos;

    public void Start()
    {
        //raftStart.SetActive(false);

    }


    void Update()
    {
        //transform.Translate(Vector3.forward * speed * direction * Time.deltaTime);

        raftPos = new Vector3(0.0f, 35.0f, -20.0f);
    }


    public void OnTriggerEnter(Collider collider)
    {

        //if (collider.tag == "Target")
        //{
        //    if (direction == 1)
        //    {
        //        direction = -1;
        //    }
        //    else
        //        direction = 1;
        //}
        if (collider.tag == "Player")
        {
            //raftStart.SetActive(true);
            //collider.transform.parent = transform;
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

        }
    }

    //public void MoveRaftNow()
    //{
    //    float step = speed * Time.deltaTime;
    //    transform.position = Vector3.MoveTowards(transform.position, target.position, step);
    //}

    public IEnumerator MoveRaftToBody()
    {
        yield return new WaitForSeconds(3);

        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);
        //iTween.MoveTo(gameObject, iTween.Hash("path", iTweenPath.GetPath("RaftPath"), "time", 15, "easetype", iTween.EaseType.easeInOutSine));
        //iTween.MoveTo(player, iTween.Hash("path", iTweenPath.GetPath("PlayerRaft"), "time", 15, "easetype", iTween.EaseType.easeInOutSine));

    }
}