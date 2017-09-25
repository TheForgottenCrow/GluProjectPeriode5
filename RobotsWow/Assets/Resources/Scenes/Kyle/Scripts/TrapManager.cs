using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapManager : MonoBehaviour
{
    [SerializeField]
    List<GameObject> m_trapgameobjects;

    List<ITrap> m_traps;

	void Start ()
    {
        m_traps = new List<ITrap>();

        //m_traps.Add(FindObjectsOfType<ITrap>());

        //foreach(GameObject trap in m_trapgameobjects)
        //{
            //m_traps.Add();
            //???????????????????????????????????????????????
        //}
	}
}
