﻿using UnityEngine;

namespace Leap.Unity {

  /// <summary>
  /// Use this component on a Game Object to allow it to be manipulated by a pinch gesture.  The component
  /// allows rotation, translation, and scale of the object (RTS).
  /// </summary>
  public class MLeapRTS : MonoBehaviour {

    public MProximityDetector mProximityDetector;

    private Transform _parent;


   void Awake()
        {
            enabled = false; //disabled, enable by Class: LeapGestureController
            if (mProximityDetector != null)
            {
                Debug.Log("Cube added into detector");
                mProximityDetector.TargetObjects.Add(this.gameObject);
            }
        }

   void onDestroy()
        {
                if (mProximityDetector != null)
                {
                    Debug.Log("Cube deleted from detector");
                    mProximityDetector.TargetObjects.Remove(this.gameObject);
                }
        }

    void OnEnable()
    {
            if (mProximityDetector != null)
            {
                _parent = transform.parent;
                transform.SetParent(mProximityDetector.transform);
                transform.localPosition.Set(0, 0, 0);
                gameObject.GetComponent<Rigidbody>().isKinematic = true;
            }
        }

     void OnDisable()
    {
            if (mProximityDetector != null)
            {
                transform.SetParent(_parent);
                gameObject.GetComponent<Rigidbody>().isKinematic = false;
            }
        }

    }

}