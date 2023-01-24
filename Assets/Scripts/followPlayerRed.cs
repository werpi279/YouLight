using UnityEngine;

public class followPlayerRed : MonoBehaviour
{

    public Transform player;
    public Vector3 redOffset;
    public float smoothRedSpeed = 0.125f;


    void FixedUpdate()
    {
        Vector3 disiredPosition = player.position + redOffset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, disiredPosition, smoothRedSpeed);
        transform.position = smoothedPosition;

        transform.LookAt(player);
    }
}