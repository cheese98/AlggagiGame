using UnityEngine;
using System.Collections;

public class Death : MonoBehaviour {

    // Use this for initialization
    AudioSource stoneDestroy;

    void Start () {
        stoneDestroy = GetComponent<AudioSource>();
    }

	void Update () {

	}
    void OnTriggerEnter (Collider other) {
        switch (other.gameObject.tag)
        {
            case "Red" : GameManager.red--; break;
            case "Blue": GameManager.blue--; break;
            default: Debug.Log("Death script Error!"); break;
        }
        stoneDestroy.Play();
        GameObject.Destroy(other.gameObject);
        
	}
}