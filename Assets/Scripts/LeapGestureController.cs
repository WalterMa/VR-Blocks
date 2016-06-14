using UnityEngine;
using System.Collections;

public class LeapGestureController : MonoBehaviour {


    private GameObject onGestureObject;

    public void setTarget(GameObject mGameObject)
    {
        if (onGestureObject != mGameObject)
        {
            onGestureObject = mGameObject;
        }
    }


    public void enableLeapRTS()
    {
        if (onGestureObject != null)
        {
            (onGestureObject.GetComponent<Leap.Unity.MLeapRTS>()).enabled = true;
            Debug.Log(onGestureObject.name + " Enabled");
        }
    }

    public void disableLeapRTS()
    {
        if(onGestureObject != null && (onGestureObject.GetComponent<Leap.Unity.MLeapRTS>()).enabled == true)
        {
            (onGestureObject.GetComponent<Leap.Unity.MLeapRTS>()).enabled = false;
            onGestureObject = null;
            Debug.Log("Disabled");
        }
    }
}
