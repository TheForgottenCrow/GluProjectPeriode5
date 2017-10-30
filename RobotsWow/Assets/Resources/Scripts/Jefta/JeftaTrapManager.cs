using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
public class JeftaTrapManager : MonoBehaviour {

    [SerializeField]
    public List<ITrap> m_TrapList;

    void Start()
    {
        m_TrapList = new List<ITrap>();
    }


    void Update()
    {

    }



    public ITrap GetTrap(int currentTrap, bool r)
    {
        ITrap giveBack = null;
        int i = r == true ? currentTrap + 1 : currentTrap - 1;
        i = i > m_TrapList.Count ? 0 : i;

        while (giveBack == null)
        {
            if (m_TrapList[i].CheckIfFree())
            {
                giveBack = m_TrapList[i];
            }
            else
            {
                i = r == true ? i + 1 : i - 1;
            }
        }

        return (giveBack);
    }
}
*/