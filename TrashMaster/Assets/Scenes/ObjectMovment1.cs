using UnityEngine;

public class ObjectMovement1 : MonoBehaviour
{
    public float movementSpeed = 5f;

    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            MoveObject(1f);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            MoveObject(-1f);
        }
    }

    private void MoveObject(float direction)
    {
        Vector3 newPosition = transform.position + new Vector3(direction * movementSpeed * Time.deltaTime, 0f, 0f);
        transform.position = newPosition;
    }
}