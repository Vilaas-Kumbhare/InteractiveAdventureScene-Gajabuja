using UnityEngine;

public class CameraFollowing : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    public float smoothSpeed = 0.125f; // Adjust for smoother/slower follow

    private void LateUpdate()
    {
        if (player != null)
        {
            // Calculate the desired position
            Vector3 targetPosition = player.position + offset;

            // Smoothly interpolate between current and target position
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, targetPosition, smoothSpeed);

            // Apply the position to the camera
            transform.position = smoothedPosition;
        }
    }
}
