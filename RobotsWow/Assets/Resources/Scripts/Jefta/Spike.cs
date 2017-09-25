using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike : ITrap {

    [SerializeField]
    private GameObject m_LongSpikes;
    private BoxCollider m_HitBox;
    private bool m_SpikesOut;

    private Vector3 m_DefCenter;
    private Vector3 m_DefSize;
    private Vector3 m_ExtCenter;
    private Vector3 m_ExtSize;


    void Start ()
    {
        m_HitBox = GetComponent<BoxCollider>();
        m_DefCenter = m_HitBox.center;
        m_DefSize = m_HitBox.size;

        m_ExtCenter = new Vector3(m_HitBox.center.x, m_HitBox.center.y - m_HitBox.size.y * 0.5f, m_HitBox.center.z);
        m_ExtSize = new Vector3(m_HitBox.size.x, (m_HitBox.size.y * 2), m_HitBox.size.z);
    }
	
	void Update ()
    {
           
        if (m_SpikesOut)
        {
            m_LongSpikes.SetActive(true);
            m_HitBox.size = m_ExtSize;
            m_HitBox.center = m_ExtCenter;
        }
        else
        {
            m_LongSpikes.SetActive(false);
            m_HitBox.center = m_DefCenter;
            m_HitBox.size = m_DefSize;
        }
	}

   


    //public void ActivateTrap()
    //{
    //    m_SpikesOut = m_SpikesOut == true ? false : true;
    //}

    //public void ResetTrap()
    //{
    //    Debug.Log("Reset trappie");
    //}

    //public bool CheckIfFree()
    //{
    //    return (true);
    //}

    public override void ActivateTrap()
    {
        m_SpikesOut = m_SpikesOut == true ? false : true;
    }

    public override void ResetTrap()
    {
        Debug.Log("Reset trappie");
    }

    public override bool CheckIfFree()
    {
        return (true);
    }
}
