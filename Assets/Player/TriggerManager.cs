using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerManager : MonoBehaviour {

    public string ExitTargetTagName = "Exit";

    public UnityEngine.Events.UnityEvent OnMazeEnds;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collided with something");




        if (other.tag == ExitTargetTagName)
        {
            Debug.Log("well done. you exited the maze");
            OnMazeEnds.Invoke();
        }
    }
}
