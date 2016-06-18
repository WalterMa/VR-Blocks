using UnityEngine;
using System.Collections;

public class LevelPass : MonoBehaviour {

    public GameObject[] triggers;
    private bool isPass = false;

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
                if (!triggers[i].GetComponent<ColiderAttachment>().IsAttached())
                {
                    isPass = false;
                    break;
                }
            }
            if (isPass)
            {
                Destroy(gameObject);
            }
        }
	}
}
