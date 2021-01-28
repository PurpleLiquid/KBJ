using UnityEngine;

public static class ControlConstants
{
    // Movement Controls (Using Input Manager)
    // Forward/Backward w/s
    public static string FORWARD_OR_BACKWARD_MOVEMENT = "Horizontal";

    // Left/Right a/d
    public static string LEFT_OR_RIGHT_MOVEMENT = "Vertical";

    // When exiting out of interactable puzzles and text
    public static KeyCode LEAVE_INTERACTION = KeyCode.X;

    // Inventory
    public static KeyCode INVENTORY = KeyCode.I;

    // Pause
    public static KeyCode PAUSE = KeyCode.P;

    // Continue dialogue
    public static KeyCode CONTINUE = KeyCode.Return;
}
