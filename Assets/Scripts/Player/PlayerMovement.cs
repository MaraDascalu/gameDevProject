using System.Diagnostics;
using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections;
using System.Collections.Generic;

public class PlayerMovement : MonoBehaviour
{
    public float _leftRightSpeed;

    public static float _forwardSpeed;

    [SerializeField]
    public Vector2 _leftRightLimits = new(-20.325f, -11.675f);

    public Vector2 _movement = Vector2.zero;

    private GameObject model;

    public GameObject player;

    static public bool ableToMove = false;

    public static int map;

    private int avatarIndex;

    IEnumerator jump()
    {
        yield return new WaitForSeconds(0.5f);
        player.GetComponent<BoxCollider>().center = new Vector3(0.0f, 0.0f, 0.0f);
        player.GetComponent<CharacterController>().center = new Vector3(0.0f, 0.0f, 0.0f);

    }

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

        avatarIndex = PlayerPrefs.GetInt("CharacterSelected");

        //Set the actual player to the one selected from the avatar menu
        model = transform.GetChild(1).GetChild(avatarIndex).gameObject;
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

                player.GetComponent<BoxCollider>().center = new Vector3(0.0f, 2.0f, 0.0f);
                player.GetComponent<CharacterController>().center = new Vector3(0.0f, 2.0f, 0.0f);

                StartCoroutine(jump());
            }

            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                model.GetComponent<Animator>().Play("Roll");
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
