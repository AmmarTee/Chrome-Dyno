using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f; // Adjust this to set your movement speed
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Input from arrow keys
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Debug.Log(horizontalInput + " " + verticalInput);
        // Calculate movement vector
        Vector2 movement = new Vector2(horizontalInput, verticalInput);

        // Move the Rigidbody
        rb.velocity = movement * speed;
    }
}
