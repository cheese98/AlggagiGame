using UnityEngine;
using System.Collections;

public class CameraRotate : MonoBehaviour {

	int r = 500;
	public static float theta = 0, speed = 0.01f;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update()
	{
		float delta = Input.GetAxis("Horizontal") * speed;
		theta -= delta;
		Vector3 v = transform.position;
		v.x = r * Mathf.Sin (theta);
		v.z = r * Mathf.Cos (theta);
		transform.position = v;
		transform.rotation = Quaternion.Euler (30 , theta * 60 + 180 , 0);
	}
	public float getAngle(){
		return transform.eulerAngles.y;
	}
}
