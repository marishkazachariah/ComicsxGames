using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMovingPlatform : MonoBehaviour {

    private PlayerController _playerCtrl;

    void Start()
    {
        _playerCtrl = FindObjectOfType<PlayerController>();

    }

    public void OnTriggerExit(Collider toolCol)
    {
        if (toolCol.gameObject.tag == "tool")
        {
            _playerCtrl.MoveOnPlatform();
        }
    }
}
