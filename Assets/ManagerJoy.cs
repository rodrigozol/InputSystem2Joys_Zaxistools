using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;

public class ManagerJoy : MonoBehaviour
{
    public int joystickIndex = 0; // Índice do joystick que você deseja verificar

    private void Update()
    {
        var joystick = InputSystem.devices[joystickIndex];

        foreach (var control in joystick.allControls)
        {
            if (control is ButtonControl button && button.wasPressedThisFrame)
            {
                Debug.Log($"Botão {button.displayName} do joystick {joystickIndex + 1} foi pressionado!");
            }
        }
    }
}
