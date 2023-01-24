using UnityEngine;
using System.Collections;

public class redLight : MonoBehaviour {

    public GameObject follower;
    public Light light;
    
    
    bool active = false;
    public Vector3 newCameraOffset;


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("red"))
            if(active == false)
            {
                
                active = true;
                follower.gameObject.SetActive(true);
                light.range = light.range + 3;

                GameObject.Find("Camera").GetComponent<followPlayer>().offset = GameObject.Find("Camera").GetComponent<followPlayer>().offset + newCameraOffset;
            }

        else
            {
                active = false;
                follower.gameObject.SetActive(false);
                light.range = light.range + 3;


                GameObject.Find("Camera").GetComponent<followPlayer>().offset = GameObject.Find("Camera").GetComponent<followPlayer>().offset - newCameraOffset;
            }
    }
}
