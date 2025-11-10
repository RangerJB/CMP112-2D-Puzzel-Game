using UnityEngine;

public class Coin : MonoBehaviour
{
    public CoinManager cm;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("player"))
        {
            Destroy(gameObject);
           cm.coinCount++;
        }
    }

}
