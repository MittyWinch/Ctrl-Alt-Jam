using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    private Rigidbody rb;
    public float jumpH;
    public float jumpForce;
    private Vector3 jump;
    private bool isgrounded;
    private void Start()
    {
        jump = new Vector3(0f, jumpH, 0f);
        rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        if (rb.velocity.y == 0)
        {
            if(Input.GetKeyDown(KeyCode.Space) && isgrounded)
            {
                rb.AddForce(jump * jumpForce, ForceMode.Impulse);
                isgrounded = false;
            }
        }
    }
    private void FixedUpdate()
    {
        transform.Rotate(0, Input.GetAxis("Horizontal") * Time.deltaTime * 25.0f, 0);
        transform.Translate(0, 0, Input.GetAxis("Vertical") * Time.deltaTime * 4.0f);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "floor")
            isgrounded = true;
    }
}
