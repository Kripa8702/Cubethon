using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{

    void LoadNextLevel()
    {
        Debug.Log("Level complete");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
