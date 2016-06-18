using UnityEngine;
using System.Collections;

public class LeapCameraMove : MonoBehaviour {

    public float MoveSpeed = 0.2f;

    private int _moveState = 0;

    public void setMoveForward()
    {
        _moveState = 1;
    }

    public void setMoveBack()
    {
        _moveState = 2;
    }

    public void setMoveStop()
    {
        _moveState = 0;
    }

    void update()
    {
        switch (_moveState)
        {
            case 0:
                break;
            case 1:
                transform.position = transform.position + Vector3.forward * Time.deltaTime * MoveSpeed;
                break;
            case 2:
                transform.position = transform.position + Vector3.back * Time.deltaTime * MoveSpeed;
                break;
            default:
                break;
        }
    }
}
