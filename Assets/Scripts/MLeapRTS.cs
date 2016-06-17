using UnityEngine;

namespace Leap.Unity {

  /// <summary>
  /// Use this component on a Game Object to allow it to be manipulated by a pinch gesture.  The component
  /// allows rotation, translation, and scale of the object (RTS).
  /// </summary>
  public class MLeapRTS : MonoBehaviour {

//		public MProximityDetector mProximityDetector;

		public LeapGestureController gestureController;

		private GameObject _handGameObject;

    private Transform _parent;

//		public void removeFromDetectorList(){
//			if (mProximityDetector != null)
//			{
//				Debug.Log("Cube removed from detector");
//				mProximityDetector.TargetObjects.Remove(this.gameObject);
//			}
//		}
//
//		public void addIntoDetectorList(){
//			if (mProximityDetector != null)
//			{
//				Debug.Log("Cube added into detector");
//				mProximityDetector.TargetObjects.Add(this.gameObject);
//			}
//		}

		public void removeFromTargetObjects(){
			if (gestureController != null)
			{
				Debug.Log("Cube removed from TargetObjects");
				gestureController.TargetObjects.Remove(this.gameObject);
			}
		}

		public void addIntoTargetObjects(){
			if (gestureController != null)
			{
				Debug.Log("Cube added into TargetObjects");
				gestureController.TargetObjects.Add(this.gameObject);
			}
		}

		public void setHandGameObject(GameObject handGameObject){
			_handGameObject = handGameObject;
		}


   void Awake()
        {
            enabled = false; //disabled, enable by Class: LeapGestureController
//			addIntoDetectorList();
			addIntoTargetObjects ();
        }


   void onDestroy()
        {
//			removeFromDetectorList ();
			removeFromTargetObjects ();
        }

    void OnEnable()
    {
//            if (mProximityDetector != null)
//            {
//                _parent = transform.parent;
//                transform.SetParent(mProximityDetector.transform);
//                transform.localPosition.Set(0, 0, 0);
//                gameObject.GetComponent<Rigidbody>().isKinematic = true;
//            }
			if (_handGameObject != null)
			{
				_parent = transform.parent;
				transform.SetParent(_handGameObject.transform);
				transform.localPosition.Set(0, 0, 0);
				gameObject.GetComponent<Rigidbody>().isKinematic = true;
			}
        }

     void OnDisable()
    {
//            if (mProximityDetector != null)
//            {
//                transform.SetParent(_parent);
//                gameObject.GetComponent<Rigidbody>().isKinematic = false;
//            }
			if (_handGameObject != null)
			{
				transform.SetParent(_parent);
				gameObject.GetComponent<Rigidbody>().isKinematic = false;
				_handGameObject = null;
			}
        }

        public void disableControl()
        {
//            transform.SetParent(_parent);
//            mProximityDetector.TargetObjects.Remove(gameObject);
//            gameObject.GetComponent<Rigidbody>().isKinematic = true;

			removeFromTargetObjects ();
			this.enabled = false;
			gameObject.GetComponent<Rigidbody>().isKinematic = true;
        }

    }
}
