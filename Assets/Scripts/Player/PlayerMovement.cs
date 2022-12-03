using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField, Range(10.0f, 100.0f)]
    private float _leftRightSpeed = 10.0f;

    [SerializeField, Range(1.0f, 10.0f)]
    private float _forwardSpeed = 3.0f;

    [SerializeField]
    private Vector2 _leftRightLimits = new(-20.325f, -11.675f);

    private Vector2 _movement = Vector2.zero;

    public GameObject model;

    static public bool ableToMove = true;

    public void Movement(InputAction.CallbackContext context)
    {
        _movement = context.ReadValue<Vector2>();
    }

    void Update()
    {
        var velocity = new Vector3(_movement.x, 0.0f, 0.0f) * _leftRightSpeed;
        var newPosition = transform.localPosition + velocity * Time.deltaTime;

        if (Input.GetButtonDown("Jump"))
        {
            model.GetComponent<Animator>().Play("Jump");
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            model.GetComponent<Animator>().Play("Slide");
            transform.Translate(0.0f, 0.0f, 5.0f);
        }

        if (ableToMove == true)
        {
            if (newPosition.x < _leftRightLimits.x)
            {
                newPosition.x = _leftRightLimits.x;
                velocity.x = 0.0f;
            }

            if (newPosition.x > _leftRightLimits.y)
            {
                newPosition.x = _leftRightLimits.y;
                velocity.x = 0.0f;
            }
        }

        transform.localPosition = newPosition;
        transform.Translate(0.0f, 0.0f, _forwardSpeed * Time.deltaTime);
    }
}
