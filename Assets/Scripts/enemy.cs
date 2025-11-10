using UnityEngine;

public class enemy : MonoBehaviour
{
   
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("player"))
        {
            Destroy(gameObject);
            
        }
      
    }
}
