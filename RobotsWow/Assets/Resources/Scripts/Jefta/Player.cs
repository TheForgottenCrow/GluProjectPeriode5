using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum e_Direction
{
    N = 0,
    E,
    S,
    W
}

public enum e_State
{
    Idle = 0,
    Moving,
    Jumping
}



public class Player : MonoBehaviour {


    [SerializeField]
    KeyCode m_KeyUp, m_KeyDown, m_KeyLeft, m_KeyRight, m_KeyJump;

    [SerializeField]
    float m_WalkSpeed, m_JumpStrength, m_NormalGravityMultiplyer, m_HeavyGrafityMultiplyer;

    Vector3 m_PlayerVelocity;
    e_Direction m_Direction;
    Rigidbody m_Rigidbody;

    void Start ()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
	}


    void Update()
    {
        // Reset input velocity
        m_PlayerVelocity.z = 0;
        m_PlayerVelocity.x = 0;
        m_PlayerVelocity.y = m_Rigidbody.velocity.y;

        Debug.Log(m_Rigidbody.velocity);



        //Get input
        if (Input.GetKey(m_KeyUp))
        {
            m_PlayerVelocity += Vector3.forward * m_WalkSpeed * Time.deltaTime;
            m_Direction = e_Direction.N;
        }
        if (Input.GetKey(m_KeyRight))
        {
            m_PlayerVelocity += Vector3.right * m_WalkSpeed * Time.deltaTime;
            m_Direction = e_Direction.E;
        }
        if (Input.GetKey(m_KeyDown))
        {
            m_PlayerVelocity += Vector3.back * m_WalkSpeed * Time.deltaTime;
            m_Direction = e_Direction.S;
        }
        if (Input.GetKey(m_KeyLeft))
        {
            m_PlayerVelocity += Vector3.left * m_WalkSpeed * Time.deltaTime;
            m_Direction = e_Direction.W;
        }

        if (Input.GetKeyDown(m_KeyJump))
        {
            m_PlayerVelocity += Vector3.up * m_JumpStrength;
        }

       
        //grafity
        {   
            if (m_Rigidbody.velocity.y != 0)
            {
                m_PlayerVelocity += Vector3.up * Physics.gravity.y * (m_NormalGravityMultiplyer) * Time.deltaTime;
            }
            if (m_Rigidbody.velocity.y > 0 && Input.GetKey(m_KeyJump))
            {
                m_PlayerVelocity += Vector3.up * Physics.gravity.y * (m_NormalGravityMultiplyer) * Time.deltaTime;
            }
            if (m_Rigidbody.velocity.y > 0 && !Input.GetKey(m_KeyJump))
            {
                m_PlayerVelocity += Vector3.up * Physics.gravity.y * (m_HeavyGrafityMultiplyer) * Time.deltaTime;
            }
        }
        
    }

    private void FixedUpdate()
    {
        // Apply Velocity
        m_Rigidbody.velocity = m_PlayerVelocity;
    }

}
