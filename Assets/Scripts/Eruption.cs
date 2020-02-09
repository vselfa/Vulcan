using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eruption : MonoBehaviour {
    public GameObject stone;
    public float fireRate = 0.5f;
    private float nextFire = 0.0f; // Initial value
    // Use this for initialization
    void Start () { 	}
    // Update is called once per frame
    void Update () {
	    if (Time.time > nextFire)   {
            nextFire = Time.time + fireRate;
            // Object, position and rotation of the new fire
            Instantiate(stone, transform.position, Random.rotation);
           } 
    }
}
