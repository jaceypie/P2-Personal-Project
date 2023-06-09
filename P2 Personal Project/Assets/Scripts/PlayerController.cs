using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb; 
    public float horizontalInput;
    public float speed = 10.0f;
    public float xRange = 4;
    public bool isOnGround = true;
    public bool gameOver;
    private Animator playerAnim;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        playerAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    
    {
        transform.Translate(Vector3.forward *Time.deltaTime * 10);
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
       
    }
    private void OnCollisionEnter(Collision collision)
    {
    if (collision.gameObject.CompareTag("Ground")) 
    {
        isOnGround = true;
    }


    else if (collision.gameObject.CompareTag("Obstacle"))
    {
        gameOver = true;
        Debug.Log("Game Over!");
    }
    }
}
