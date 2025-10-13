using UnityEngine;
using UnityEngine.SceneManagement;

public class Carregarcena : MonoBehaviour
{
    public string sceneName;
   
    public void Load()
    {
        SceneManager.LoadScene(sceneName);
    }
}