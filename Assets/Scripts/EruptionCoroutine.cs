using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EruptionCoroutine : MonoBehaviour {
    public GameObject stone;      
    public float fireRate = 0.5f;
    // Use this for initialization
    void Start () { // Registering the coroutine
        StartCoroutine(ThrowStone());
     }
    // The method for the coroutine
    IEnumerator ThrowStone ()  {
        // Star the coroutine after 2 seconds
        yield return new WaitForSeconds(2);
        while (true)  {
            Instantiate(stone, transform.position, Random.rotation);
            // To call the coroutine after a period of time
            yield return new WaitForSeconds (fireRate);
        }
    }
}

