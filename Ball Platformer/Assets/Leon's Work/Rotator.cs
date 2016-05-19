using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour {

    private Rigidbody rb;
    
    // Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        rb.rotation = rb.rotation * Quaternion.Euler(2.0f, 0.0f, 0.0f);
    }
}
