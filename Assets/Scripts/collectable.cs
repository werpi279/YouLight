using UnityEngine;

public class collectable : MonoBehaviour {

    //private float countPickUp = 8;
    [Space]
    [Space]
    [Space]
    [Space]
    [Space]
    [Space]
    [Space]

    public Light playerLight;
    public Light pickupLight;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("pickup"))
        {
            for (int i = 0; i < 20; i++)
            {
                pickupLight.intensity = pickupLight.intensity - i;
            }
            //other.gameObject.SetActive(false);
            //countPickUp = countPickUp + 3;
            playerLight.range = playerLight.range +3;
            playerLight.intensity = playerLight.intensity +2;
        }
    }
}
