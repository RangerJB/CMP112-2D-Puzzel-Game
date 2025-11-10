using Unity.VisualScripting;
using UnityEngine;

public class Moveable_Box : MonoBehaviour
{
    public float push = 5;
    private Rigidbody2D rb;

    private void OnCollision2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            Vector2 contact = collision.GetContact(0).normal;

            if (Mathf.Abs(contact.y) < 0.5)
            {
                Vector2 pushDirection = new Vector2(-contact.x, 0);
                rb.linearVelocity = new Vector2(pushDirection.x * push, rb.linearVelocity.y);
            }
        }
            
        
    }
}
