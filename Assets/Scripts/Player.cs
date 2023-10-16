using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    [SerializeField] private Transform groundCheckTransform;
    public Rigidbody rb;
    public float jumpForce = 5f;
    private bool jumpKeyWasPressed;
    private float horizontalInput;
    private bool isGrounded;
    [SerializeField] private LayerMask playerMask;
    public int Respawn;
    public float threshold;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space)) {
            Debug.Log("Space Pressed");
            jumpKeyWasPressed = true;
        }

        horizontalInput = Input.GetAxis("Horizontal");

    }

    private void FixedUpdate()
    {
        if (transform.position.y < threshold)
        {
            SceneManager.LoadScene(Respawn);
        }
        rb.velocity = new Vector3(0, rb.velocity.y, horizontalInput * 2);

        if (Physics.OverlapSphere(groundCheckTransform.position, 0.1f, playerMask).Length == 0)
        {
            return;
        }

        if (jumpKeyWasPressed == true)
        {
            rb.AddForce(Vector3.up * 1.8f, ForceMode.VelocityChange);
            jumpKeyWasPressed= false;
            
        }

        

        
    }

    





}
