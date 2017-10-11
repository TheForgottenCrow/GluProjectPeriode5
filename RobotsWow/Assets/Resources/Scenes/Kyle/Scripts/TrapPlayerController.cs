using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapPlayerController : MonoBehaviour
{
    int m_selectedtrap;

    [SerializeField]
    int m_trapplayerindex;

    [SerializeField]
    KeyCode player_nexttrapkey;
    [SerializeField]
    KeyCode player_previoustrapkey;
    [SerializeField]
    KeyCode player_activatetrapkey;

    TrapPlayerController[] m_theghosts;

    TrapManager m_trapmanager;

    [SerializeField]
    List<Transform> m_activationposition;

    void Awake()
    {
        m_selectedtrap = 0;
    }

    void Start ()
    {
        m_theghosts = GameObject.FindObjectsOfType<TrapPlayerController>();
        m_trapmanager = GameObject.FindObjectOfType<TrapManager>();

        Debug.Log(m_trapplayerindex);
        m_theghosts[m_trapplayerindex].m_selectedtrap = m_trapplayerindex;
    }
	
	void Update ()
    {
        Debug.Log(m_selectedtrap);

        if (Input.GetKeyDown(player_nexttrapkey))
        {
            if (m_selectedtrap != m_trapmanager.GetAllTraps().Length - 1)
            {
                if (m_trapmanager.GetAllTraps()[m_selectedtrap].IsTrapBeingUsed() == false)
                {
                    m_selectedtrap += 1;
                }
                else
                {
                    foreach (Trap trap in m_trapmanager.GetAllTraps())
                    {
                        if(trap.IsTrapBeingUsed() == false)
                        {
                            //m_trapmanager
                        }
                    }
                }
            }
        }
        if (Input.GetKeyDown(player_previoustrapkey))
        {
            if (m_selectedtrap != 0)
            {
                m_selectedtrap -= 1;
            }
        }

        transform.position = m_activationposition[m_selectedtrap].position;

        if (m_trapmanager.GetAllTraps()[m_selectedtrap].PlayerMayPress())
        {
            if (Input.GetKeyDown(player_activatetrapkey))
            {
                m_trapmanager.ActivateTrap(m_selectedtrap);
            }
        }
    }
}
