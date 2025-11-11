using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public Vector2 checkpoint;
    public PlayerMovement SP;
   void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("player"))
        {
            SP.StartPos = checkpoint;
                
        }
    }
}
