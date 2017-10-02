using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ITrap
{
    void Activate();
    void Reset();
}

public class Trap : MonoBehaviour
{
    [SerializeField]
    float m_trapendcounter;
    float m_trapresettimer;
    [SerializeField]
    float m_deactivatetraptimer;
    float m_deactivationtimer;

    bool m_trapisactive;

    [SerializeField]
    KeyCode m_trapactivationkey;

    [SerializeField]
    private PlayerController m_player;

    Animator m_animator;

    void Start()
    {
        m_player.TrapHasHitEvent += Reset;

        m_animator = GetComponent<Animator>();

        m_animator.SetInteger("State", 0);

        m_deactivationtimer = 10;
    }

    void Update()
    {
        //m_trapresettimer = m_trapresettimer + Time.deltaTime;
        m_deactivationtimer = m_deactivationtimer + Time.deltaTime;

        if (m_deactivationtimer > m_deactivatetraptimer)
        {
            if (Input.GetKeyDown(m_trapactivationkey))
            {
                //timer werkt
                Activate();
                m_deactivationtimer = 0;
                m_trapisactive = true;
            }
        }
        /*
        if (m_trapresettimer > m_trapendcounter && m_trapisactive == true)
        {
            Debug.Log(m_trapresettimer);
            Reset();
            m_trapresettimer = 0;
            m_trapisactive = false;
        }
        */
        //if(m_trapisactive == true)
        //{
        //    Reset();
        //    m_trapisactive = false;
        //}
    }

    public void Activate()
    {
        //Debug.Log("Time For Change");
        m_animator.SetInteger("State", 1);
    }

    public void Idle()
    {
        //Debug.Log("Naaah I will just go back");
        m_animator.SetInteger("State", 0);
    }

    public void Reset()
    {
        //Debug.Log("Naaah I will just go back");
        m_animator.SetInteger("State", 2);
    }
}

