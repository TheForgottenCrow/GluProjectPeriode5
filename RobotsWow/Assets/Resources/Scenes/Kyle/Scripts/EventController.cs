using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventController : MonoBehaviour
{
    List<ITrap> m_traps;

	void Start ()
    {
        m_traps = new List<ITrap>();

        m_traps.Add(new PushTrap());
	}
}
