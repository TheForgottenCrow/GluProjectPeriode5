using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ITrap
{
    void Activate();
    void Reset();
}

<<<<<<< HEAD
public class Trap : MonoBehaviour, ITrap
=======
public class Trap : MonoBehaviour
>>>>>>> DeveloperGeneral
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
<<<<<<< HEAD
    
=======

>>>>>>> DeveloperGeneral
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
<<<<<<< HEAD
        m_trapresettimer = m_trapresettimer + Time.deltaTime;
        m_deactivationtimer = m_deactivationtimer + Time.deltaTime;

        if (m_trapisactive == false && m_deactivationtimer > m_deactivatetraptimer)
        {
            if (Input.GetKeyDown(m_trapactivationkey))
            {
=======
        //m_trapresettimer = m_trapresettimer + Time.deltaTime;
        m_deactivationtimer = m_deactivationtimer + Time.deltaTime;

        if (m_deactivationtimer > m_deactivatetraptimer)
        {
            if (Input.GetKeyDown(m_trapactivationkey))
            {
                //timer werkt
>>>>>>> DeveloperGeneral
                Activate();
                m_deactivationtimer = 0;
                m_trapisactive = true;
            }
        }
<<<<<<< HEAD

        if (m_trapresettimer > m_trapendcounter && m_trapisactive == true)
        {
            Reset();
            m_trapresettimer = 0;
            Debug.Log("Meow");
        }
=======
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
>>>>>>> DeveloperGeneral
    }

    public void Activate()
    {
<<<<<<< HEAD
        m_animator.SetInteger("State", 1);
    }

    public void Reset()
    {
        m_animator.SetInteger("State", 2);
    }

}
=======
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

>>>>>>> DeveloperGeneral
