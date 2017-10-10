using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ITrap
{
    void Activate();
    void Reset();
    void Idle();
}

public class Trap : MonoBehaviour
{
    [SerializeField]
    int m_trapindex;

    [SerializeField]
    float m_deactivatetraptimer;
    float m_deactivationtimer;

    bool m_trapisactive;
    bool m_activatetrap;
    bool m_playermayactivatethetrap;

    [SerializeField]
    List<Collider> m_trapdeathtriggers;

    [SerializeField]
    private PlayerController m_player;

    Animator m_animator;

    void Start()
    {
        foreach(Collider collider in GetComponentsInChildren<Collider>())
        {
            if(collider.isTrigger)
            {
                m_trapdeathtriggers.Add(collider);
            }
        }

        foreach (Collider collider in m_trapdeathtriggers)
        {
            collider.enabled = false;
        }

        m_animator = GetComponent<Animator>();

        if (m_animator != null)
        {
            m_animator.SetInteger("State", 0);
        }

        m_deactivationtimer = 10;
    }

    void Update()
    {
        //m_trapresettimer = m_trapresettimer + Time.deltaTime;
        m_deactivationtimer = m_deactivationtimer + Time.deltaTime;

        if (m_deactivationtimer > m_deactivatetraptimer)
        {
            m_playermayactivatethetrap = true;

            if(m_activatetrap == true)
            {
                //timer werkt
                Activate();
                m_deactivationtimer = 0;
                m_trapisactive = true;
                m_activatetrap = false;
            }
        }
        if(m_deactivationtimer < m_deactivatetraptimer)
        {
            m_playermayactivatethetrap = false;
        }
    }

    public void Idle()
    {
        switch (m_trapindex)
        {
            case 0:
                m_animator.SetInteger("State", 0);
                Debug.Log("PushTrap Idle");
                break;

            case 1:
                m_animator.SetInteger("State", 0);
                Debug.Log("Spike Idle");
                break;

            case 2:
                Debug.Log("Fall Idle");
                m_animator.SetInteger("State", 0);
                break;
        }
    }

    public void Activate()
    {
        switch (m_trapindex)
        {
            case 0:
                foreach (Collider dtrigger in m_trapdeathtriggers)
                {
                    dtrigger.enabled = true;
                }
                Debug.Log("PushTrap Activate");
                m_animator.SetInteger("State", 1);
                break;

            case 1:
                foreach (Collider dtrigger in m_trapdeathtriggers)
                {
                    dtrigger.enabled = true;
                }
                Debug.Log("Spike Activate");
                m_animator.SetInteger("State", 1);
                break;

            case 2:
                foreach (Collider dtrigger in m_trapdeathtriggers)
                {
                    dtrigger.enabled = true;
                }
                Debug.Log("Fall Activate");
                m_animator.SetInteger("State", 1);
                break;
        }
    }

    public void Reset()
    {
        switch (m_trapindex)
        {
            case 0:
                foreach (Collider dtrigger in m_trapdeathtriggers)
                {
                    dtrigger.enabled = false;
                }
                Debug.Log("PushTrap Reset");
                m_animator.SetInteger("State", 2);
                break;

            case 1:
                foreach (Collider dtrigger in m_trapdeathtriggers)
                {
                    dtrigger.enabled = false;
                }
                Debug.Log("Spike Reset");
                m_animator.SetInteger("State", 2);
                break;

            case 2:
                foreach (Collider dtrigger in m_trapdeathtriggers)
                {
                    dtrigger.enabled = true;
                }
                Debug.Log("Fall Reset");
                m_animator.SetInteger("State", 2);
                break;
        }
    }

    public void ActivateTheTrap(bool activation)
    {
        m_activatetrap = activation;
    }

    public bool PlayerMayPress()
    {
        return m_playermayactivatethetrap;
    }

    public int GetTrapIndex
    {
        get
        {
            return m_trapindex;
        }
    }
}