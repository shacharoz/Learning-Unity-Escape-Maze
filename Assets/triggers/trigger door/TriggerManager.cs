using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerManager : MonoBehaviour {

    public string ExitTargetTagName = "Exit";

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == ExitTargetTagName)
        {
            Debug.Log("well done. you exited the maze");
        }
    }
}
