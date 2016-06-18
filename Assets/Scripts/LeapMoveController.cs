using UnityEngine;
using System.Collections;

public class LeapMoveController : MonoBehaviour {

    public float moveSpeed = 0.2f;

	private Rigidbody rb;
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	
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
        if (Input.GetKey(KeyCode.R))
        {
            transform.Translate(moveSpeed * Vector3.up * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.F))
        {
            transform.Translate(moveSpeed * Vector3.down * Time.deltaTime);
        }
    }

	void FixedUpdate(){
		rb.velocity = Vector3.zero;
	}
}
