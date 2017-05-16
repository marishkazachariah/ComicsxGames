using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {

    public GameObject raft;
    public GameObject particles;
    private MovingObjectManager _moveObject;
    private RaftPlatformMovement _raftController;

    void Start ()
    {
        _moveObject = FindObjectOfType<MovingObjectManager>();
        _raftController = FindObjectOfType<RaftPlatformMovement>();
        //raft.SetActive(false);
    }

    void Update () 
	{
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("MainMenu");
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "activateRaft")
        {
            _raftController.StartScaleRaft();
            //raft.SetActive(true);
            particles.SetActive(false);
        }
    }

 //   public void OnCollisionEnter (Collision collision)
	//{
 //       if (collision.gameObject.tag == "tool")
 //       {
 //           MoveOnPlatform();
 //       }
       
 //   }

    public void MoveOnPlatform()
    {
        _moveObject.IntroPlatform();
    }
}
