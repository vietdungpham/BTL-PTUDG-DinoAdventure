using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsGrounded : MonoBehaviour
{
    // Start is called before the first frame update

    public  JumpingCharacter charac;
    // Start is called before the first frame update
    void Start()
    {
        charac = gameObject.GetComponentInParent<JumpingCharacter>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("ground"))
        {
            charac.isGrounded = true;
            charac.isJumping = false;
        }            
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("ground"))
        {
            charac.isGrounded = true;
            charac.isJumping = false;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("ground"))
        {
            charac.isGrounded = false;
            charac.isJumping = true;
        }
    }
}
