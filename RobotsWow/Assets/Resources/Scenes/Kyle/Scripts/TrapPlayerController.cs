using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapPlayerController : MonoBehaviour
{
    int m_selectedtrap;

    TrapManager m_trapmanager;

    [SerializeField]
    List<Transform> m_activationposition; 

	void Start ()
    {
        m_selectedtrap = 0;

        m_trapmanager = GameObject.FindObjectOfType<TrapManager>();
    }
	
	void Update ()
    {
        Debug.Log(m_selectedtrap);

        if (Input.GetKeyDown(KeyCode.RightBracket))
        {
            if (m_selectedtrap != m_trapmanager.GetAllTraps().Length - 1)
            {
                m_selectedtrap += 1;
            }
        }
        if (Input.GetKeyDown(KeyCode.LeftBracket))
        {
            if (m_selectedtrap != 0)
            {
                m_selectedtrap -= 1;
            }
        }

        transform.position = m_activationposition[m_selectedtrap].position;

        switch (m_selectedtrap)
        {
            case 0:
                //m_trapplayericon.transform = 
                break;
        }

        if (Input.GetKeyDown(KeyCode.O))
        {
            m_trapmanager.ActivateTrap(m_selectedtrap);
        }
    }
}
