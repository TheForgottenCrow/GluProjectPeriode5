using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapManager : MonoBehaviour
{
    [SerializeField]
    Trap[] m_traps;

    float m_maxwaittime;

	void Start ()
    {
        //m_trapgameobjects = GameObject.FindGameObjectsWithTag("Trap");
        Trap[] traps = GameObject.FindObjectsOfType<Trap>();
        m_traps = new Trap[traps.Length];

        for(int i = 0; i < traps.Length; i++)
        {
            m_traps[traps[i].GetTrapIndex] = traps[i];
        }
	}

    public void ActivateTrap(int trapindex)
    {
        m_traps[trapindex].ActivateTheTrap(true);
    }

    public int GetNextTrap(int startindex)
    {
        for(int i = startindex + 1; i < m_traps.Length; i++)
        {
            if(m_traps[i].IsTrapBeingUsed() == false)
            {
                return i;
            }
        }
        return startindex;
    }

    public int GetPreviousTrap(int startindex)
    {
        for(int i = startindex - 1; i < m_traps.Length; i--)
        {
            if(m_traps[i].IsTrapBeingUsed() == false)
            {
                return i;
            }
        }
        return startindex;
    }

    public Trap GetTrap(int trapindex)
    {
        if(trapindex < 0 || trapindex >= m_traps.Length)
        {
            return null;
        }
        return m_traps[trapindex];
    }
}
