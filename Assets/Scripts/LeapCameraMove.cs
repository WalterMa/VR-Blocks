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
		Vector3 d;
        switch (_moveState)
        {
            case 0:
                break;
		case 1:
			d = Quaternion.Euler (transform.rotation.eulerAngles) * Vector3.forward;
			transform.parent.Translate(MoveSpeed *d * Time.deltaTime);
                break;
            case 2:
			d = Quaternion.Euler (transform.rotation.eulerAngles) * Vector3.back;
			transform.parent.Translate(MoveSpeed * d * Time.deltaTime);
                break;
            default:
                break;
        }
    }
}
