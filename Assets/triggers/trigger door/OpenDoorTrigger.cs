using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoorTrigger : MonoBehaviour {

    public Transform Door;
    public float ZValueClosed;
    public float ZValueOpened;


    // Use this for initialization
    void Start () {

        CloseDoorNow();

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            OpenDoorNow();

        }
    }

    private void OpenDoorNow()
    {
        Door.position = new Vector3(Door.position.x, Door.position.y, ZValueOpened);
    }

    private void CloseDoorNow()
    {
        Door.position = new Vector3(Door.position.x, Door.position.y, ZValueClosed);
    }
}
