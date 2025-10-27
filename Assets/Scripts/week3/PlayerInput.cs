using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInput : MonoBehaviour
{
    [Header("Movement Settings")]
    [SerializeField] float speed = 5f;
    [SerializeField] bool normalizeDiagonal = true;

    [Header("Optional Tweaks")]
    [SerializeField] bool allowGamepad = true;
    [SerializeField] bool allowKeyboard = true;
    [SerializeField] bool sprintWithShiftOrRB = true;
    [SerializeField] float sprintMultiplier = 1.5f;
    //...rest of code...
    void Update()
    {
        Vector2 move = Vector2.zero;
        if (allowKeyboard)
        {
            var kb = Keyboard.current;
            if (kb != null)
            {
                if (kb.wKey.isPressed || kb.upArrowKey.isPressed) { 
                    move.y += 1;
                    print("up up");
                }
                if (kb.sKey.isPressed || kb.downArrowKey.isPressed) move.y -= 1;
                if (kb.dKey.isPressed || kb.rightArrowKey.isPressed) move.x += 1;
                if (kb.aKey.isPressed || kb.leftArrowKey.isPressed) move.x -= 1;
            }
        }
        var pad = allowGamepad ? Gamepad.current : null;
        if (pad != null)
        {
            Vector2 stick = pad.leftStick.ReadValue();
            if (stick.sqrMagnitude > move.sqrMagnitude) move = stick;
        }
        if (normalizeDiagonal && move.sqrMagnitude > 1f) move.Normalize();
        float currentSpeed = speed;
        if (sprintWithShiftOrRB)
        {
            bool sprint = false;
            var kb = Keyboard.current;
            if (kb != null && (kb.leftShiftKey.isPressed || kb.rightShiftKey.isPressed)) sprint = true;
            if (pad != null && (pad.rightShoulder.isPressed || pad.leftShoulder.isPressed)) sprint = true;
            if (sprint) currentSpeed *= sprintMultiplier;
        }
        transform.position += (Vector3)(move*currentSpeed*Time.deltaTime);
    }
}
