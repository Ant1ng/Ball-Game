using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{

    private Rigidbody rb;

    public float speed;
    public float jump;

    public GameController gameController;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = Vector3.zero;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Movement();
        //bool force = false;

        //Vector3 v = rb.velocity;
        //float x = Input.GetAxis("Horizontal");
        //float y = Input.GetAxis("Vertical");
        //float z = 0.0f;

        //gameController.scoreText.text = "Velocity: " + rb.velocity.y;

        //if (Input.GetKey(KeyCode.M) && rb.velocity.y == 0.0f)
        //{
        //    z = jump;
        //}

        //v.x = speed * x;
        //v.y = v.y + z;
        //v.z = speed * y;

        //rb.velocity = v;

    }

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("shit"))
        {
            other.gameObject.SetActive(false);
            gameController.addScore(1);
        }
    }

    void Movement()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        float z = 0.0f;

        if (Input.GetKey(KeyCode.M))
        {
            z = jump;
        }

        transform.Translate(new Vector3(x, z/speed, y) * speed * Time.smoothDeltaTime);
    }
}
