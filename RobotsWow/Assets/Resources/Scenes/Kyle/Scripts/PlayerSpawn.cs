using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawn : MonoBehaviour {
    
    [SerializeField]
    Transform m_spawnpoint;

    [SerializeField]
    PushTrap m_trap;

	void Start ()
    {
        Reset();

        AddEvent(m_trap);
	} 

    void Reset()
    {
        transform.position = m_spawnpoint.position;
    }

    void AddEvent(PushTrap trap)
    {
        trap.TrapHasHitEvent += Reset;
    }
}
