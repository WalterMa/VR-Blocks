using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

    public GameObject Menu;
    public GameObject Level1;
    public GameObject Level2;
	public Leap.Unity.HandAttachments handAttachment;

	private GameObject _level1;
	private GameObject _level2;

	public void hideMenu()
    {
        Menu.SetActive(false);
    }

    public void showMenu()
    {
        Menu.SetActive(true);
    }

	public void startNormalMode(){
		if(_level1 != null){
			Destroy (_level1);
		}
		if (_level2 != null) {
			Destroy (_level2);
		}
		_level1 = GameObject.Instantiate (Level1);
		_level2 = GameObject.Instantiate (Level2);
		handAttachment.enabled = true;
	}

	public void startFreeMode(){
		if(_level1 != null){
			Destroy (_level1);
		}
		if (_level2 != null) {
			Destroy (_level2);
		}
		handAttachment.enabled = true;
	}

	public void exitGame(){
	}
}
