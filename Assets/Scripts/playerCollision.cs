using UnityEngine;

public class playerCollision : MonoBehaviour {

    public playerMovement movement;
    //public GameObject gameManager;     useless


    private void OnCollisionEnter(Collision collision) //collisionInfo
    {
        
        if (collision.collider.tag == "obstacle")
        {
            Debug.Log("We hit an obstacle!");
            movement.enabled = false;    //a.k.a. GetComponent<playerMovement>().enabled = false;
            FindObjectOfType<gameManager>().endGame();
        }
    }
}
