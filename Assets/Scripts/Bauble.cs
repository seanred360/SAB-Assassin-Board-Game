using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bauble : MonoBehaviour
{
    public float m_rotateSpeed;

    // Update is called once per frame
    void Update()
    {
         transform.Rotate(0, Time.deltaTime + m_rotateSpeed, 0);
    }
}
