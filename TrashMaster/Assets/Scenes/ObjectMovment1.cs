using UnityEngine;

public class ObjectMovement1 : MonoBehaviour
{
    public float movementSpeed = 5f;

    private void Update()
    {
        // Check for Q or E button press
        if (Input.GetKey(KeyCode.W))
        {
            MoveObject(1f); // Move left
        }
        else if (Input.GetKey(KeyCode.S))
        {
            MoveObject(-1f); // Move right
        }
    }

    private void MoveObject(float direction)
    {
        Vector3 newPosition = transform.position + new Vector3(direction * movementSpeed * Time.deltaTime, 0f, 0f);
        transform.position = newPosition;
    }
}