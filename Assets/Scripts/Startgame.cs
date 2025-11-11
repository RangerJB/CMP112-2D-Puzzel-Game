using UnityEngine;
using UnityEngine.SceneManagement;

public class Startgame : MonoBehaviour
{
    public void Playgame()
    {
        SceneManager.LoadSceneAsync(1);
        
    }
    public void selectlevel()
    {
        SceneManager.LoadSceneAsync(2);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
