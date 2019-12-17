using UnityEngine;
using System.Collections;

public class BallCollision : MonoBehaviour {

    // Use this for initialization
    public Rigidbody rb;
    void Start () {
        rb = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
	
	}
    /*void OnCollisionEnter(Collision other)
    {
        if (rb.velocity.magnitude > 0 && (other.collider.tag == "Red" || other.collider.tag == "Blue"))
        {
            rb.AddForce(new Vector3(-rb.velocity.x, 0, -rb.velocity.z), ForceMode.VelocityChange);
            StartCoroutine("Wait");
        }
    }*/
    IEnumerator Wait()
    {
        //yield return new WaitForEndOfFrame();
        yield return new WaitForSeconds(0.1f);
    }
}
