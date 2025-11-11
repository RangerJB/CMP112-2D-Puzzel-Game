using UnityEngine;
using UnityEngine.SceneManagement;

public class Level_select1 : MonoBehaviour
{
    public void levelselect1()
    {
        SceneManager.LoadSceneAsync(1);
        
    }
    public void levelselect2()
    {
        
        SceneManager.LoadSceneAsync(3);
    }
}

