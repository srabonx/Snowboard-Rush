using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    Rigidbody2D rb2d;
    [SerializeField] float m_torque = 1.0f;
    SurfaceEffector2D m_surfaceEffector;

    float m_normalEffectorSpeed = 0;
    float m_boostEffectorSpeed = 0;

    bool m_canMove = true;


    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        m_surfaceEffector = FindObjectOfType<SurfaceEffector2D>();
        m_normalEffectorSpeed = m_surfaceEffector.speed;
        m_boostEffectorSpeed = m_normalEffectorSpeed * 1.4f;
    }

    void Update()
    {
        if(m_canMove)
        {
            RotatePlayer();
            BoostPlayer();
        }
    }

    public void DisableControl()
    {
        m_canMove = false;
    }
    private void BoostPlayer()
    {
        if(Input.GetKey(KeyCode.W))
        m_surfaceEffector.speed = m_boostEffectorSpeed;
        else
        m_surfaceEffector.speed = m_normalEffectorSpeed;
    }

    private void RotatePlayer()
    {
        if (Input.GetKey(KeyCode.A))
        {
            rb2d.AddTorque(m_torque);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb2d.AddTorque(-m_torque);
        }
    }
}
