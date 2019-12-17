using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
	public static int turn = 0, red = 5, blue = 5;
	public static bool allowShoot = true;
    public static float pow = 8.0f;
	void Start(){
		player1Turn ();
	}
	void Update(){/*
		if(Input.GetKey(KeyCode.Space))
			Application.LoadLevel ("Play");*/
	}
	public void player1Turn(){
		transform.position = new Vector3 (0, 300, -500);
		transform.rotation = Quaternion.Euler (30, 0, 0);
		turn++;
	}
	public void player2Turn(){
		transform.position = new Vector3 (0, 300, 500);
		transform.rotation = Quaternion.Euler (30, 180, 0);
		turn++;
	}

}
