using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    [SerializeField]
    private float m_JumpStrength, m_JumpTime, m_MoveSpeed;
    
	
	void Start ()
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
	}
}
