using UnityEngine;
using System.Collections;
using Leap;

namespace Leap.Unity{
  public class HandEnableDisable : HandTransitionBehavior {

		public LeapGestureController gestureController;
        public LeapCameraMove cameraMove;
    
    protected override void Awake() {
      base.Awake();
      gameObject.SetActive(false);
    }

  	protected override void HandReset() {
      gameObject.SetActive(true);
  	}
  
  	protected override void HandFinish () {
            if (gestureController != null)
            {
                Debug.Log("Realease Lego");
                gestureController.disableLeapRTS();
            }
            if (cameraMove != null)
            {
                Debug.Log("Stop Move");
                cameraMove.setMoveStop();
            }
            gameObject.SetActive(false);
            
        }
  	
  }
}
