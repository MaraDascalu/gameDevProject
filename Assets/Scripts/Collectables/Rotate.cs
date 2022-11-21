using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float rotationSpeed = 1.0f;

    void Update()
    {
        transform.Rotate(0, rotationSpeed, 0, Space.World);
    }
}
