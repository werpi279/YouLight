using UnityEngine;

public class endTrigger : MonoBehaviour {

    public gameManager gameManager;

    /*private*/ void OnTriggerEnter()  //(Collider other)
    {
        gameManager.CompleteLevel();
    }
}
