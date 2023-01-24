using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class popUpScene : MonoBehaviour {

    public GameObject[] pickups;
    public float distance;

    private void Start()
    {
        pickups = GameObject.FindGameObjectsWithTag("pickup");
    }

    private void Update()
    {
        foreach (GameObject pickup in pickups)
        {
            if (distance > pickup.transform.position.x - transform.position.x)
            {
                pickup.transform.GetChild(0).gameObject.SetActive(true);
                pickup.transform.GetChild(1).gameObject.SetActive(true);
            }

            if(transform.position.x > pickup.transform.position.x + 20f)
            {
                pickup.transform.GetChild(0).gameObject.SetActive(false);
                pickup.transform.GetChild(1).gameObject.SetActive(false);
            }
        }
        
    }
}