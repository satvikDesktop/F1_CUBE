using UnityEngine.SceneManagement;
using UnityEngine;

public class Main : MonoBehaviour
{
    // Start is called before the first frame update
    public void StartGame()
    {
     SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);   
    }
}