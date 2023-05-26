using UnityEngine;

public class ObjectMovement2 : MonoBehaviour
{
    public float movementSpeed = 5f;

    private void Update()
    {
        // Check for arrow key press
        float horizontalInput = Input.GetAxis("Horizontal");

        // Exclude A, D, W, S keys from movement
        if (horizontalInput != 0f)
        {
            MoveObject(horizontalInput);
        }
    }

    private void MoveObject(float direction)
    {
        Vector3 newPosition = transform.position + new Vector3(direction * -1 * movementSpeed * Time.deltaTime, 0f, 0f);
        transform.position = newPosition;
    }
}