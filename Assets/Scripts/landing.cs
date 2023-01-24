using UnityEngine;
using UnityEngine.SceneManagement;

public class landing : MonoBehaviour
{

    public void startGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
