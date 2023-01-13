using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public float _leftRightSpeed;

    public static float _forwardSpeed;

    [SerializeField]
    public Vector2 _leftRightLimits = new(-20.325f, -11.675f);

    public Vector2 _movement = Vector2.zero;

    public GameObject model;

    static public bool ableToMove = false;

    public static int map;

    public void Movement(InputAction.CallbackContext context)
    {
        if (ableToMove == true)
            _movement = context.ReadValue<Vector2>();
    }

    void Start()
    {
        _leftRightSpeed = 10.0f;
        _forwardSpeed = 10.0f;

        if (map == 1)
        {
            var startPosition = new Vector3(0.0f, 0.0f, 0.0f);
            startPosition.x = -16.0f;
            startPosition.y = 198.357f;
            startPosition.z = -285.0f;
            transform.localPosition = startPosition;
        }
        else if (map == 2)
        {
            var startPosition = new Vector3(0.0f, 0.0f, 0.0f);
            startPosition.x = -602.625f;
            startPosition.y = 207.257f;
            startPosition.z = -516.0f;
            transform.localPosition = startPosition;
        }
    }

    void Update()
    {
        var velocity = new Vector3(_movement.x, 0.0f, 0.0f) * _leftRightSpeed;
        var newPosition = transform.localPosition + velocity * Time.deltaTime;

        if (map == 1)
        {
            _leftRightLimits.x = -20.325f;
            _leftRightLimits.y = -11.675f;
        }
        else if (map == 2)
        {
            _leftRightLimits.x = -607.25f;
            _leftRightLimits.y = -598.0f;
        }

        if (ableToMove == true)
        {
            if (Input.GetButtonDown("Jump"))
            {
                model.GetComponent<Animator>().Play("Jump");
            }

            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                model.GetComponent<Animator>().Play("Slide");
                transform.Translate(0.0f, 0.0f, 5.0f);
            }

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
