using UnityEngine;

public class ObjectMovement3 : MonoBehaviour
{
    public float movementSpeed = 5f;

    private void Update()
    {
        // Check for horizontal movement
        float horizontalInput = Input.GetAxis("Horizontal");
        MoveObject(horizontalInput, 0f);

    }

    private void MoveObject(float horizontalDirection, float verticalDirection)
    {
        Vector3 newPosition = transform.position + new Vector3(horizontalDirection * -1 * movementSpeed * Time.deltaTime, 0f, verticalDirection * movementSpeed * Time.deltaTime);
        transform.position = newPosition;
    }
}
