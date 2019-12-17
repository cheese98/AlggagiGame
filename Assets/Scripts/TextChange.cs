using UnityEngine;
using System.Collections;

public class TextChange : MonoBehaviour {
	public TextMesh tm;
	// Use this for initialization
	void Start () {
		tm = GetComponent<TextMesh>();
	}
	
	// Update is called once per frame
	void Update () {
        /*if (GameManager.red == 0 && GameManager.blue == 0) tm.text = "Draw!!!";
        else if (GameManager.red == 0) tm.text = "Blue team won!";
        else if (GameManager.blue == 0) tm.text = "Red team won!";*/
        if (GameManager.red == 0 || GameManager.blue == 0) StartCoroutine("Winner");
        else {
			if (GameManager.turn % 2 == 1) {
                tm.text = "Turn: " + GameManager.turn + "\n" + GameManager.red + " : " + GameManager.blue + "\nRed player's turn";
				transform.position = new Vector3 (100, 250, 0);
				transform.rotation = Quaternion.Euler (0, 0, 0);
			} else {
                tm.text = "Turn: " + GameManager.turn + "\n" + GameManager.red + " : " + GameManager.blue + "\nBlue player's turn";
				transform.position = new Vector3 (-100, 250, 0);
				transform.rotation = Quaternion.Euler (0, 180, 0);
			}
		}
	}
    IEnumerator Winner()
    {
        GameManager.allowShoot = false;
        yield return new WaitForSeconds(3.0f);
        if (GameManager.red == 0 && GameManager.blue == 0) tm.text = "Draw!";
        else if (GameManager.blue == 0)
        {
            tm.text = "Red team won!";
            if (GameManager.turn % 2 == 0) GameObject.Find("Main Camera").GetComponent<GameManager>().player2Turn();
        }
        else if (GameManager.red == 0)
        {
            tm.text = "Blue team won!";
            if (GameManager.turn % 2 == 1) GameObject.Find("Main Camera").GetComponent<GameManager>().player2Turn();
        }
        else Debug.Log("Error! Can't find winner.");
        tm.text = tm.text + "\npress Alt+F4 to close";
    }
}
