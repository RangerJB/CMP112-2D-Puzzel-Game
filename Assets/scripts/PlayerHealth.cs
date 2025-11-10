using UnityEngine;
using UnityEngine.UI;
public class PlayerHealth : MonoBehaviour
{
   public int health;
    public Text healthText;


    void Update()
    {
        healthText.text = "Health: " + health.ToString();
    }
}
