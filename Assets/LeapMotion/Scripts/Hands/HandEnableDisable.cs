using UnityEngine;
using System.Collections;
using Leap;

namespace Leap.Unity{
  public class HandEnableDisable : HandTransitionBehavior {

		public LeapGestureController gestureController;
    
    protected override void Awake() {
      base.Awake();
      gameObject.SetActive(false);
    }

  	protected override void HandReset() {
      gameObject.SetActive(true);
  	}
  
  	protected override void HandFinish () {
  		gameObject.SetActive(false);
			if (gestureController != null) {
                Debug.Log("000000");
				gestureController.disableLeapRTS ();
			}
  	}
  	
  }
}
