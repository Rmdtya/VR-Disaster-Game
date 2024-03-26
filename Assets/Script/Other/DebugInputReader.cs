using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class DebugInputReader : MonoBehaviour
{
    public InputActionProperty MoveAction;
    public Vector2 move;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        move = MoveAction.action.ReadValue<Vector2>();
    }
}
