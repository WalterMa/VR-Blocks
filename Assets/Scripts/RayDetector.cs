using UnityEngine;
using System.Collections;

public class RayDetector : MonoBehaviour {
	float lastTime = 0;
	RaycastHit hitif;
	public GameObject lego;
	public float dectectDistance = 0.1f;

	// Use this for initialization
	void Start () {
		lastTime = Time.time;
//		lego = Resources.Load("Square") as GameObject;

	}
	
	// Update is called once per frame
	void Update () {
		bool myCollider = Physics.Raycast(transform.position,transform.forward,out hitif);
//		Debug.Log ("ray!!");

		float currTime = Time.time;
		if (myCollider && hitif.distance <= 0.5 && hitif.collider.gameObject.tag == "Lego") {
			lastTime = currTime;
			return;
		}

//		Debug.Log ("delta time="+ (currTime - lastTime));
		if (currTime - lastTime > 0.8) {
			lastTime = currTime;
			Debug.Log ("not collided!!");
			Vector3 position = new Vector3(this.gameObject.transform.position.x,
				(float)(this.transform.position.y+dectectDistance),
				(float)(this.transform.position.z+dectectDistance));
			GameObject go = (GameObject)Instantiate(this.lego,position,this.gameObject.transform.rotation);
			go.tag = "Lego";
		}


	}
}
