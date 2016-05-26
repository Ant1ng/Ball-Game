using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{

    private Rigidbody rb;

    public float speed;
    public float jump;

    private CameraController cameraController;
    public GameObject camera;
    public float cameraSpeed;

    private GameController gameController;
    public GameObject gameControllerObject;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        gameController = gameControllerObject.GetComponent<GameController>();
        cameraController = camera.GetComponent<CameraController>();
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

        if (x != 0)
        {
            cameraController.Rotate(x, cameraSpeed);
        }

        if (y != 0.0f)
        {
            transform.Translate(new Vector3 (
                (rb.position.x - camera.transform.position.x),
                0.0f,
                rb.position.z - camera.transform.position.z) * speed * y * Time.smoothDeltaTime);
            camera.transform.Translate(new Vector3(
                (rb.position.x - camera.transform.position.x),
                0.0f,
                rb.position.z - camera.transform.position.z) * speed * y * Time.smoothDeltaTime);
        }
    }
}
