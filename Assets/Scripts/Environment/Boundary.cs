using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundary : MonoBehaviour
{
    public static float leftSide = -20.325f;
    public static float rightSide = -11.675f;
    public float left;
    public float right;

    void Update()
    {
        left = leftSide;
        right = rightSide;
    }
}