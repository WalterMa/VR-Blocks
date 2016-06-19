using UnityEngine;
using System.Collections;

public class LevelPass : MonoBehaviour {

    public GameObject[] triggers;
    private bool isPass = false;
    private float startTime;

    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        if (!isPass)
        {
            isPass = true;
            for(int i = 0; i < triggers.Length; i++)
            {
                if (triggers[i].GetComponent<ColiderAttachment>().target == null || !triggers[i].GetComponent<ColiderAttachment>().target.getFinishLerp())
                {
                    isPass = false;
                    break;
                }
            }
            if (isPass)
            {
                startTime = Time.time;
            }
        }
        if (isPass)
        {
            float distCovered = (Time.time - startTime) * 1f;
            float fracJourney = distCovered / 5f;
            transform.position = Vector3.Lerp(new Vector3(transform.position.x, 0, transform.position.z), new Vector3(transform.position.x, -5f, transform.position.z), fracJourney);
        }
    }
}
