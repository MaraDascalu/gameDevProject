using UnityEngine;

public class AvatarRotate : MonoBehaviour
{
    public float rotationSpeed = 2.5f;

    void Update()
    {
        transform.Rotate(0, rotationSpeed, 0, Space.World);
    }
}
