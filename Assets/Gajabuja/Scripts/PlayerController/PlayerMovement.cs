using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // Speed of the player

    private void Update()
    {
        // Get input from arrow keys or WASD
        float horizontal = Input.GetAxis("Horizontal"); // Left/Right arrow keys or A/D
        float vertical = Input.GetAxis("Vertical");     // Up/Down arrow keys or W/S

        // Calculate movement vector
        Vector3 movement = new Vector3(horizontal, vertical, 0f);

        // Move the player
        transform.Translate(movement * moveSpeed * Time.deltaTime);
    }
}
