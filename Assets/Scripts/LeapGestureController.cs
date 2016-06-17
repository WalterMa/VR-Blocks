using UnityEngine;
using System.Collections;

public class LeapGestureController : MonoBehaviour {

	public ArrayList TargetObjects = new ArrayList ();

	private GameObject _targetGameObject;

	public void setTarget(GameObject targetGameObject)
    {
		if (_targetGameObject != targetGameObject)
        {
			_targetGameObject = targetGameObject;
        }
    }


    public void enableLeapRTS()
    {
        if (_targetGameObject != null)
        {
			(_targetGameObject.GetComponent<Leap.Unity.MLeapRTS> ()).enabled = true;
            Debug.Log(_targetGameObject.name + " Enabled");
        }
    }

    public void disableLeapRTS()
    {
        if(_targetGameObject != null)
        {
            (_targetGameObject.GetComponent<Leap.Unity.MLeapRTS>()).enabled = false;
            _targetGameObject = null;
            Debug.Log("Disabled");
        }
    }
}
