using UnityEngine;
using System.Collections;

public class playerMovement : MonoBehaviour
{
    [Space]
    [Header("Movement")]

    public Rigidbody rb;
    
    [Range(0.5f, 3f)]
    public float movementForce = 500f;
    [Range(0f, 1f)]
    public float runningForce = 1000f;

    bool redOn = false;

    [Space]
    [Header("Collectable")]

    public Light playerLight;
    //public Light pickupLight;


    [Space]
    [Header("Game over")]

    public GameObject dontFall;


    // "Fixed" Update is called once per frame while using physics!
    void FixedUpdate()
    {
        rb.AddForce(runningForce, 0, 0);


        if (Input.GetKey("d")) //improve movement! (i.e. bool)
        {
            rb.AddForce(0, 0, -movementForce * Time.deltaTime, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(0, 0, movementForce * Time.deltaTime, ForceMode.VelocityChange);
        }

        if (rb.position.z > 24.5 || rb.position.z < -24.5)
        {
            dontFall.gameObject.SetActive(true);
        }

        if (rb.position.z > 26 || rb.position.z < -26)
        {
            FindObjectOfType<gameManager>().endGame();
        }
    }

        
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("pickup"))
        {
            other.gameObject.SetActive(false);


            playerLight.range = playerLight.range + 3;
            playerLight.intensity = playerLight.intensity + 1;
        }

        if (other.gameObject.CompareTag("red"))
        {
            if (redOn == false)
            {
                runningForce = runningForce * 3f;
                redOn = true;
            }

            else
            {
                runningForce = runningForce / 3f;
                redOn = false;
            }
        }
    }
}