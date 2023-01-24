using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour {

    bool gameHasEnded = false;
    public float restartDelay = 3f;
    public GameObject completeLevelUI;
    public Rigidbody player;

    public void endGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;

            player.useGravity= true;

            //Debug.Log("game over");
            Invoke("Restart", restartDelay); //function name, seconds of delay
        }        
    }

    void Restart ()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        
        gameHasEnded = false;

        player.useGravity = false;

        player.GetComponent<playerMovement>().enabled = true;
        FindObjectOfType<rewinding>().startRewind();
    }


    public void CompleteLevel()
    {
        //Debug.Log("level complete");
        completeLevelUI.SetActive(true);
    }
}
