using UnityEngine;
using System.Collections;

public class LeapCameraMove : MonoBehaviour {

    public float MoveSpeed = 0.2f;

    private int _moveState = 0;

    public void setMoveForward()
    {
		Debug.Log ("Move Forward Enabled");
        _moveState = 1;
    }

    public void setMoveBack()
    {
		Debug.Log ("Move Back Enabled");
        _moveState = 2;
    }

    public void setMoveStop()
    {
		Debug.Log ("Move Disabled");
        _moveState = 0;
    }

    void Update()
    {
		transform.parent.rotation = transform.rotation;
		transform.localRotation = Quaternion.identity;
        switch (_moveState)
        {
            case 0:
                break;
            case 1:
			transform.parent.Translate(MoveSpeed * Vector3.forward * Time.deltaTime);
                break;
            case 2:
			transform.parent.Translate(MoveSpeed * Vector3.back * Time.deltaTime);
                break;
            default:
                break;
        }
    }
}
