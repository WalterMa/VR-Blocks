﻿using UnityEngine;
using System.Collections;

public class LeapMoveController : MonoBehaviour {

    public float moveSpeed = 0.2f;
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(moveSpeed * Vector3.forward * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(moveSpeed * Vector3.back * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(moveSpeed * Vector3.left * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(moveSpeed * Vector3.right * Time.deltaTime);
        }
    }
}