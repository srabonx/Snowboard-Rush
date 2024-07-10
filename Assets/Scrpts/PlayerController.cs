using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    Rigidbody2D rb2d;
    [SerializeField] float m_torque = 1.0f;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.A))
        {
            rb2d.AddTorque(m_torque);
        }
        if(Input.GetKey(KeyCode.D))
        {
            rb2d.AddTorque(-m_torque);
        }
    }
}
