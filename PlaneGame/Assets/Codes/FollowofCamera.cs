using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FollowofCamera : MonoBehaviour {

    public Transform Plane;
    public float xThings;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(Plane.position.x+xThings,0,-10); 
	}
}
