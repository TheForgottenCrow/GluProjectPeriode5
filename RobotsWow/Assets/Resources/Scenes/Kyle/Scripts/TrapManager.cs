using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapManager : MonoBehaviour
{
    [SerializeField]
    Trap[] m_traps;

    [SerializeField]
    GameObject m_trapplayericon;

    int m_selectedtrap;

	void Start ()
    {
        //m_trapgameobjects = GameObject.FindGameObjectsWithTag("Trap");
        Trap[] traps = GameObject.FindObjectsOfType<Trap>();
        m_traps = new Trap[traps.Length];

        for(int i = 0; i < traps.Length; i++)
        {
            m_traps[traps[i].GetTrapIndex] = traps[i];
        }
        
        m_selectedtrap = 0;
	}

    public void ActivateTrap(int trapindex)
    {
        m_traps[trapindex].ActivateTheTrap(true);
    }

    public void SelectTrap(int trap)
    {
        m_selectedtrap = trap;
    }

    public Trap[] GetAllTraps()
    {
        return m_traps;
    }
}
