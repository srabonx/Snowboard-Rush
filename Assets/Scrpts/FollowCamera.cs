using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{

    GameObject m_followObject;

    void Start()
    {
        m_followObject = GameObject.Find("Circle");
    }

    void LateUpdate()
    {
        Vector3 pos = m_followObject.transform.position;
        pos.z = -10f;
        transform.position = pos;   
    }
}
