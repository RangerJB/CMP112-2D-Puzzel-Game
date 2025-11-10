using UnityEngine;
using UnityEngine.UI;
public class healthpack : MonoBehaviour
{
    public PlayerHealth PH;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("player"))
        {
            PH.health++;
            Destroy(gameObject);
            
        }
    }
}
