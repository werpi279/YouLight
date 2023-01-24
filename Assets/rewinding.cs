using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rewinding : MonoBehaviour {

    bool isRewinding = false;
    List<Vector3> positions;
    Rigidbody rb;
    public float rewindTime = 3f;


    void Start () {
        positions = new List<Vector3>();
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (isRewinding)
        {
            rewind();
        }
        else
        {
            record();
        }
    }

    void rewind()
    {
        if (positions.Count > 0)
        {
            transform.position = positions[0];
            positions.RemoveAt(0);
        }
        else
        {
            stopRewinding();
        }
    }

    void record()
    {
        if (positions.Count > Mathf.Round(rewindTime / Time.fixedDeltaTime))
        {
            positions.RemoveAt(positions.Count - 1);
        }

        positions.Insert(0, transform.position);
    }

    /*void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            startRewind();
        }
    }*/

    public void startRewind()
    {
        isRewinding = true;
        rb.isKinematic = true;
    }

    public void stopRewinding()
    {
        isRewinding = false;
        rb.isKinematic = false;
    }

}