using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

    public GameObject Menu;
    public GameObject Level1;
    public GameObject Level2;
    public GameObject HandAttachment;

	public void hideMenu()
    {
        Menu.SetActive(false);
    }

    public void showMenu()
    {
        Menu.SetActive(true);
    }
}
