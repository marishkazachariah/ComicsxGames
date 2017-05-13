using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getMorePills : MonoBehaviour {

    private InstantiatePills instantiatePills;

    void Start ()
    {
        instantiatePills = FindObjectOfType<InstantiatePills>();
    }
	
	void Update () {
		
	}

    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "pill")
        {         
            instantiatePills.GetMorePills();
        }
    }
}
