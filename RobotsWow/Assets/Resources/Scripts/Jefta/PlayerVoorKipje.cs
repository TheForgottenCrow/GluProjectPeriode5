using System.Collections;
using System.Collections.Generic;
using UnityEngine;

<<<<<<< HEAD:RobotsWow/Assets/Resources/Scripts/Jefta/Player.cs
public class Player : MonoBehaviour {

    [SerializeField]
<<<<<<< HEAD
    private float m_JumpStrength, m_JumpTime, m_MoveSpeed;
    
	
	void Start ()
=======
    KeyCode m_KeyUp, m_KeyDown, m_KeyLeft, m_KeyRight, m_KeyJump;

    [SerializeField]
    float m_WalkSpeed, m_JumpStrength, m_NormalGravityMultiplyer, m_HeavyGrafityMultiplyer;

    Vector3 m_PlayerVelocity;
    e_Direction m_Direction;
    Rigidbody m_Rigidbody;

    void Start ()
>>>>>>> DeveloperGeneral
=======
enum EPlayerState
{
    Idle = 0,
    Runnig

}


public class PlayerVoorKipje : MonoBehaviour
{
    [Header("Physics"), Space()]
    [SerializeField] private float m_JumpStrength;
    [SerializeField] private float m_MoveSpeed;
    [SerializeField] private float m_FallGravity;
    [SerializeField] private float m_LowJumpGravity;
    [SerializeField] private LayerMask m_GroundLayer;

    private float m_XVelocity;
    private float m_ZVelocity;

    private Vector3 m_DirectionMem;


    private Rigidbody m_RB;
    private CapsuleCollider m_Col;
    private Animator m_Animator;

    [Space()]
    [SerializeField, Header("Debug")]
    private Vector3 d_Velocity;


    private void Awake()
>>>>>>> DeveloperGeneral:RobotsWow/Assets/Resources/Scripts/Jefta/PlayerVoorKipje.cs
    {
		
	}
	
	
	void Update ()
    {
        m_JumpTime += Time.deltaTime;

        

        if (m_JumpTime < 1.5f)
        {
            gameObject.transform.position += Vector3.up * m_JumpStrength * Time.deltaTime;
        }

        //Temp input
        if (Input.GetKey(KeyCode.Space))
        {
            m_JumpTime = 0f;
            
        }
<<<<<<< HEAD
	}
=======

       
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

>>>>>>> DeveloperGeneral
}
