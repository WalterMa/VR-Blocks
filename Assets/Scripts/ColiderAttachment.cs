﻿using UnityEngine;
using System.Collections;

public class ColiderAttachment : MonoBehaviour {

    public LegoProperty.LegoNameType legoName;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    void OnTriggerEnter(Collider other)
    {
        LegoProperty legoProperty = other.gameObject.GetComponent<LegoProperty>();
        if (legoProperty != null && legoProperty.legoName == legoName)
        {
            other.gameObject.GetComponent<Leap.Unity.MLeapRTS>().disableControl();
            legoProperty.startLerp(other.gameObject.transform, gameObject.transform);
        }
    }
}