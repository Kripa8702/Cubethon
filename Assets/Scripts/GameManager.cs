using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool hasGameEnded = false;
    public float restartDelay = 1f;

    public GameObject compeleteLevelUI;

    public void LevelComplete()
    {
        compeleteLevelUI.SetActive(true);
    }

    public void EndGame()
    {
        if (!hasGameEnded)
        {
            hasGameEnded = true;
            Debug.Log("GAME OVER");
            Invoke("Restart", restartDelay);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
