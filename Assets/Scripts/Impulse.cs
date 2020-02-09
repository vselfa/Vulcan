using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Impulse : MonoBehaviour {
    private Rigidbody rigidBody;
    public float forceImpulse = 1.0f;
    // Use this for initialization
    void Start () {
        rigidBody = GetComponent<Rigidbody>();
        // The initial impulse to be applied to every stone only 	// when they are created
        rigidBody.AddForce(Vector3.up * forceImpulse,  ForceMode.Impulse);
    }
    // Update is called once per frame
    void Update () {	}
}
