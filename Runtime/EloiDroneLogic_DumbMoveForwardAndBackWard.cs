using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EloiDroneLogic_DumbMoveForwardAndBackWard : MonoBehaviour
{
    public PushGenericMono_GamepadInspectorInput m_gamepad;


    public float m_timeBetweenAction = 1f;

    IEnumerator Start()
    {
        m_gamepad.SetLeftJoystickVertical(-1);
        while (true) {
            yield return new WaitForSeconds(m_timeBetweenAction);
            m_gamepad.SetRightJoystickVertical(1);
            m_gamepad.SetLeftJoystickHorizontal(1);
            yield return new WaitForSeconds(m_timeBetweenAction);
            m_gamepad.SetRightJoystickVertical(0);
            yield return new WaitForSeconds(m_timeBetweenAction*2);
            m_gamepad.SetRightJoystickVertical(-1);
            m_gamepad.SetLeftJoystickHorizontal(-1);
            yield return new WaitForSeconds(m_timeBetweenAction);
            m_gamepad.SetRightJoystickVertical(0);
            yield return new WaitForEndOfFrame();
        }

    }
}
