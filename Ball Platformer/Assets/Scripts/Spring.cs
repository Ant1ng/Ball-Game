using UnityEngine;
using System.Collections;

public class Spring : MonoBehaviour {

    public GameObject ball;
    
    // Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    void OnTriggerEnter (Collider other)
    {
        if (gameObject.GetComponent<sprong>().enabled)
            other.GetComponent<Rigidbody>().velocity = new Vector3 (0.0f, 50.0f, 0.0f);
    }
}
