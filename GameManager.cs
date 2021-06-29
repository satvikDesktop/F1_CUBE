
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public GameObject completeLevelUI;

    public float restartDelay=1f;

    public void NextScene (){
          SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }
   public void CompleteLevel () {
      completeLevelUI.SetActive(true);
       Invoke("NextScene",2);  // 2 second delay after level completed UI
   }
    public void EndGame()
    {
        if (gameHasEnded==false){
            gameHasEnded = true;
            Invoke("Restart",restartDelay);
        }
    }

    void Restart () {
     SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

}
