using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float speed = 10.0f;
    [SerializeField]
    private float RotationSpeed = 1.0f;
    [SerializeField]
    private Rigidbody player;
    [SerializeField]
    private GameObject Ball;
    [SerializeField]
    private GameObject SpawnPoint;
    public float power = 0.0f;
    private Vector3 force;
    // Start is called before the first frame update
    void Start()
    {
        player = gameObject.GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("space"))
        {
            power += 0.01f;
        }
        if (Input.GetKeyUp("space"))
        {
            GameObject ball = Instantiate(Ball);
            ball.transform.position = new Vector3(SpawnPoint.transform.position.x, SpawnPoint.transform.position.y - 1.0f, SpawnPoint.transform.position.z);
            Vector3 angle = transform.forward;
            force = new Vector3(angle.x * power, angle.y * power + 5.0f, angle.z * power);
            ball.GetComponent<Rigidbody>().AddForce(force, ForceMode.Impulse);
            power = 0.0f;

        }
        if (Input.GetAxisRaw("Horizontal") > 0.0f)
        {
            // move right
            player.velocity = new Vector3(-speed * Time.deltaTime, 0.0f,0.0f);
        }

        if (Input.GetAxisRaw("Horizontal") < 0.0f)
        {
            // move left
            player.velocity = new Vector3(speed * Time.deltaTime, 0.0f, 0.0f);

        }
        if (Input.GetKey("w"))
        {
            transform.Rotate(new Vector3(0.0f, RotationSpeed, 0.0f));
        }
        if (Input.GetKey("s"))
        {
            transform.Rotate(new Vector3(0.0f, -RotationSpeed, 0.0f));
        }
        transform.position += player.velocity;
    }
}
