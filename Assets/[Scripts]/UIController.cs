using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class UIController : MonoBehaviour
{
    public static bool jumpButtonPressed;

    public void OnJumpButton_Down()
    {
        jumpButtonPressed = true;
    }

    public void OnJumpButton_Up()
    {
        jumpButtonPressed = false;
    }
}
