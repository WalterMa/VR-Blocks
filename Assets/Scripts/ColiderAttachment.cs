using UnityEngine;
using System.Collections;

public class ColiderAttachment : MonoBehaviour {

    public LegoProperty.LegoNameType legoName;

    private Collider mcollider;

	// Use this for initialization
	void Start () {
        mcollider = GetComponent<BoxCollider>();
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    void OnTriggerEnter(Collider other)
    {
        LegoProperty legoProperty = other.gameObject.GetComponent<LegoProperty>();
        if (legoProperty != null && legoProperty.legoName == legoName)
        {
            //other.gameObject.SetActive(false);
            other.gameObject.GetComponent<Leap.Unity.MLeapRTS>().disableControl();
            //other.gameObject.SetActive(true);
            legoProperty.startLerp(other.gameObject.transform, gameObject.transform);
        }
    }
}
