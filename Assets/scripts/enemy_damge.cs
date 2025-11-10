using UnityEngine;

public class enemy_damge : MonoBehaviour
{
    public PlayerHealth PH;
    

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("player"))
        {
            PH.health--;
        }
    }
}
