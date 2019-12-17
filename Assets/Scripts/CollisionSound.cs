using UnityEngine;
using System.Collections;


public class CollisionSound : MonoBehaviour
{

    // Use this for initialization
    AudioSource stoneCollide;

    void Start()
    {
        stoneCollide = GetComponent<AudioSource>();
    }

    void Update()
    {

    }
    void OnCollisionEnter(Collision other)
    {
        if (transform.position.x > other.collider.transform.position.x && (other.collider.tag == "Blue" || other.collider.tag == "Red")) stoneCollide.Play();
    }
}