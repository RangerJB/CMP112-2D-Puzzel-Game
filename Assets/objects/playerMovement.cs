using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    //variables
    public float moveSpeed = 5f;
    public float jumpForce = 10f;
    public float jumpForceBig = 20f;
    private Rigidbody2D rb;
    private bool isGrounded;

    // player health 
    public PlayerHealth PH;
    public Vector2 StartPos;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        StartPos = transform.position;
    }
    
    void Update()
    {
        // Left anad right movement
        float moveInput = Input.GetAxisRaw("Horizontal");
        rb.linearVelocity = new Vector2(moveInput * moveSpeed, rb.linearVelocity.y);





        // Jump
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            // Big Jump
            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForceBig);

            }

            else
            { //normal jump
                rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
            }
        }
        if (PH.health == 0)
        {
            transform.position = StartPos;
            PH.health = 1;
        }

    }

    // Ground collison
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.contacts[0].normal.y > 0.5f)
            isGrounded = true;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        isGrounded = false;
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Death"))
        {
            transform.position = StartPos;
            PH.health--;
        }
        if (collision.gameObject.CompareTag("TheSun"))
        {
            SceneManager.LoadSceneAsync(3);
        }
        if (collision.gameObject.CompareTag("TheSun2"))
        {
            SceneManager.LoadSceneAsync(0);
        }
    }
    
}
