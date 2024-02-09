using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJumpController : MonoBehaviour
{
    [SerializeField]Rigidbody rb;


    public float JumpForce = 5;
    public bool isGrounded = true;

    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            Debug.Log($"Key Pressed {KeyCode.Space}");
            rb.AddForce(new Vector3(0,JumpForce,0),ForceMode.Impulse);
            isGrounded = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }
}
