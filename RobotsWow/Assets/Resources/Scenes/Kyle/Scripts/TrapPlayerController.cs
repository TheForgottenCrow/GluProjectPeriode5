using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class TrapPlayerController : MonoBehaviour
{
    int m_selectedtrap;
    int m_lasttrap;
    int m_nexttrap;

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
        m_trapmanager.GetTrap(m_selectedtrap).UseThisTrap(true);
    }
	
	void Update ()
    {
        if (Input.GetKeyDown(player_nexttrapkey))
        {
            int newtrapindex = m_trapmanager.GetNextTrap(m_selectedtrap);

            if(newtrapindex != m_selectedtrap)
            {
                m_trapmanager.GetTrap(m_selectedtrap).UseThisTrap(false);
                m_trapmanager.GetTrap(newtrapindex).UseThisTrap(true);

                m_selectedtrap = newtrapindex;
            }
        }

        if (Input.GetKeyDown(player_previoustrapkey))
        {
            int newtrapindex = m_trapmanager.GetPreviousTrap(m_selectedtrap);

            if(newtrapindex != m_selectedtrap)
            {
                m_trapmanager.GetTrap(m_selectedtrap).UseThisTrap(false);
                m_trapmanager.GetTrap(newtrapindex).UseThisTrap(true);

                m_selectedtrap = newtrapindex;
            }
        }

        transform.position = m_activationposition[m_selectedtrap].position;

        if (m_trapmanager.GetTrap(m_selectedtrap).PlayerMayPress())
        {
            if (Input.GetKeyDown(player_activatetrapkey))
            {
                m_trapmanager.ActivateTrap(m_selectedtrap);
            }
        }
    }
}
