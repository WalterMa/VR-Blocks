using UnityEngine;
using System.Collections;

public class BoxDetector : MonoBehaviour {
	
	float lastTime = 0;
	float currTime = 0;
	public GameObject lego;
	public float initHeight = 0.4f;

	// Use this for initialization
	void Start () {
		lastTime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		currTime = Time.time;

		//		Debug.Log ("delta time="+ (currTime - lastTime));
		if (currTime - lastTime > 0.8) {
			lastTime = currTime;
			Debug.Log ("not collided!!");
			Vector3 position = new Vector3(this.gameObject.transform.position.x,
				this.gameObject.transform.position.y + initHeight,
				(float)(this.transform.position.z));
			GameObject go = (GameObject)Instantiate(this.lego,position,this.gameObject.transform.rotation);
			go.SetActive(true);
			go.tag = "Lego";
		}
	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "Lego") {
			lastTime = currTime;
		}
	}

	void OnTriggerStay(Collider other){
		if (other.gameObject.tag == "Lego") {
			lastTime = currTime;
		}
	}

	void OnTriggerExit(Collider other){
	}
}
