using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    // store horizontal input
    float m_h;
    public float H { get { return m_h; } }

    // store the vertical input 
    float m_v;
    public float V { get { return m_v; } }

    // global flag for enabling and disabling user input
    bool m_inputEnabled = false;
    public bool InputEnabled { get { return m_inputEnabled; } set { m_inputEnabled = value; } }

    int m_maxKeystrokesAllowed;
    public int MaxKeyStrokesAllowed { get { return m_maxKeystrokesAllowed; } set { m_maxKeystrokesAllowed = value; } }



    void Update()
    {
        if (m_maxKeystrokesAllowed <= 0)
        {
            //m_inputEnabled = false;
        }
        else m_inputEnabled = true;
    }

    public void SetMaxKeystrokes(int diceNumberThrown)
    {
        m_maxKeystrokesAllowed = diceNumberThrown;
    }

    // get keyboard input
    public void GetKeyInput()
    {
        //// if input is enabled, just get the raw axis data from the Horizontal and Vertical virtual axes (defined in InputManager)
        //if (m_inputEnabled)
        //{
        //    m_h = Input.GetAxisRaw("Horizontal");
        //    m_v = Input.GetAxisRaw("Vertical");
        //}
        //// if input is disabled, ensure that extra key input does not cause unintended movement
        //else
        //{
        //    m_h = 0f;
        //    m_v = 0f;
        //}
    }

    public void OnPointerDownHorizontal(int direction)
    {
        if (m_inputEnabled)
            m_h = direction;
    }
    public void OnPointerUpHorizontal()
    {
        if (m_inputEnabled)
            m_h = 0;
    }
    public void OnPointerDownVertical(int direction)
    {
        if (m_inputEnabled)
            m_v = direction;
    }
    public void OnPointerUpVertical()
    {
        if (m_inputEnabled)
            m_v = 0;
    }

}
