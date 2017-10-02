using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapPlayerController : MonoBehaviour {

    [SerializeField]
    TrapManager m_TrapManager;
    [SerializeField]
    int m_TrapIndex;
    [SerializeField]
    ITrap m_CurrentTrap;

    //public void initialisePlayer(int index ,ITrap asignedTrap)
    //{
    //    m_TrapIndex = index;
    //    m_CurrentTrap = asignedTrap;
    //}

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            m_CurrentTrap = m_TrapManager.GetTrap(m_TrapIndex, false);
        }
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            m_CurrentTrap = m_TrapManager.GetTrap(m_TrapIndex, true);
        }


        if (Input.GetKeyUp(KeyCode.Space))
        {
            m_CurrentTrap.ActivateTrap();
        }

    }
}
