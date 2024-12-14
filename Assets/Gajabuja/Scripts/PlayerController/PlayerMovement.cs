using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // Speed of the player

    private void Update()
    {
        Vector3 movement = Vector3.zero;

        // Check if running on a touch-supported device
        if (Input.touchCount > 0)
        {
            // Get the first touch
            Touch touch = Input.GetTouch(0);

            // Translate touch position to movement (drag-based control)
            if (touch.phase == TouchPhase.Moved)
            {
                Vector2 touchDelta = touch.deltaPosition;
                movement = new Vector3(touchDelta.x, touchDelta.y, 0f).normalized;
            }
        }
        else
        {
            // Fallback for keyboard/controller input
            float horizontal = Input.GetAxis("Horizontal"); // Left/Right arrow keys or A/D
            float vertical = Input.GetAxis("Vertical");     // Up/Down arrow keys or W/S
            movement = new Vector3(horizontal, vertical, 0f);
        }

        // Move the player
        transform.Translate(movement * moveSpeed * Time.deltaTime);
    }
}
