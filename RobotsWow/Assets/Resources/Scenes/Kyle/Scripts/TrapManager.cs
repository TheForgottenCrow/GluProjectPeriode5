using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapManager : MonoBehaviour
{
    [SerializeField]
    Trap[] m_traps;

    [SerializeField]
    GameObject m_trapplayericon;

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

    public Trap[] GetAllTraps()
    {
        return m_traps;
    }
}
