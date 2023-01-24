using System;
using UnityEngine;

public class finalAnimation : MonoBehaviour
{
    public GameObject finale;

    private void OnCollisionEnter(Collision collision)
    {
        //Debug.Log("animationStarting");
        finale.GetComponent<Animation>().Play("finalAnimation");
    }
}