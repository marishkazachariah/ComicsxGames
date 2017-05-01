using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaftPlatformMovement : MonoBehaviour
{

    [SerializeField]
    private GameObject player;

    public void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Player")
        {
            StartCoroutine("MoveRaftToBody");
            //collider.transform.parent = transform;
        }
    }
    //public void OnTriggerExit(Collider collider)
    //{
    //    if (collider.tag == "Player")
    //    {
    //        collider.transform.parent = transform;
    //    }
    //}

    public IEnumerator MoveRaftToBody()
    {
        yield return new WaitForSeconds(3);
        iTween.MoveTo(gameObject, iTween.Hash("path", iTweenPath.GetPath("RaftPath"), "time", 5, "easetype", iTween.EaseType.easeInOutSine));
        iTween.MoveTo(player, iTween.Hash("path", iTweenPath.GetPath("RaftPath"), "time", 5, "easetype", iTween.EaseType.easeInOutSine));
    }
}