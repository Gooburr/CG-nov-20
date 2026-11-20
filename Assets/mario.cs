using UnityEngine;

public class mario : MonoBehaviour
{
    private Rigidbody rb;
    public float speed = 5.0f;
    public float jumpForce = 5f;
    private float horizontalMovement = 0f;
    private bool grounded = true;
    private bool jump = false;
    public GameObject bridge;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            horizontalMovement = 1f;

        }else if (Input.GetKey(KeyCode.LeftArrow))
        {
            horizontalMovement = -1f;

        }
        else
        {
            horizontalMovement = 0;
        }
        if (grounded && Input.GetKeyDown(KeyCode.Space))
        {
            jump = true;

        }
    }
    private void FixedUpdate()
    {
        rb.linearVelocity = new Vector3 (horizontalMovement * speed, rb.linearVelocity.y, 0);
        if (jump)
        {
            rb.AddForce(new Vector3(0, jumpForce, 0));
            jump = false;
            Debug.Log("Jump");
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        grounded = true;
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        grounded = false;
    }
    private void OnTriggerEnter(Collider other)
    {
        bridge.SetActive(false);
    }
}
