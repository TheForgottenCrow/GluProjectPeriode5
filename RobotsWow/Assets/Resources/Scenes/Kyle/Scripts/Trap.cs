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
    int m_trapindex;

    [SerializeField]
    float m_trapendcounter;
    float m_trapresettimer;
    [SerializeField]
    float m_deactivatetraptimer;
    float m_deactivationtimer;

    bool m_trapisactive;
    bool m_activatetrap;

    [SerializeField]
    List<Collider> m_trapdeathtriggers;

    [SerializeField]
    private PlayerController m_player;
<<<<<<< HEAD
    
=======

>>>>>>> DeveloperGeneral
    Animator m_animator;

    void Start()
    {
        foreach(Collider collider in GetComponentsInChildren<Collider>())
        {
            m_trapdeathtriggers.Add(collider);
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
            if(m_activatetrap == true)
            {
                //timer werkt
>>>>>>> DeveloperGeneral
                Activate();
                m_deactivationtimer = 0;
                m_trapisactive = true;
                m_activatetrap = false;
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
        }
    }

    public void Idle()
    {
        //Debug.Log("Naaah I will just go back");
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
        }
    }

    public void Reset()
    {
        //Debug.Log("Naaah I will just go back");
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
        }
    }

<<<<<<< HEAD
>>>>>>> DeveloperGeneral
=======
    public void ActivateTheTrap(bool activation)
    {
        m_activatetrap = activation;
    }

    public int GetTrapIndex
    {
        get
        {
            return m_trapindex;
        }
    }
}
>>>>>>> DeveloperGeneral
