using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ITrap
{
    void Activate();
    void Reset();
}

public delegate void OnTrapHit();

public class PushTrap : MonoBehaviour, ITrap
{
    public event OnTrapHit TrapHasHitEvent;

    Animator m_animator;

    [SerializeField]

    void Start()
    {
        m_animator = GetComponent<Animator>();

        m_animator.SetInteger("State", 0);

        TrapHasHitEvent += Reset;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            Activate();
        }

        if (Input.GetKeyDown(KeyCode.Equals))
        {
            Reset();
        }
    }

    public void Activate()
    {
        m_animator.SetInteger("State", 1);
    }

    public void Reset()
    {
        m_animator.SetInteger("State", 0);
    }

    public void OnTriggerEnter(Collider other)
    {
        if(TrapHasHitEvent != null)
        {
            if(other.tag == "Player1")
            {
                Debug.Log("BOEM!!!");

                TrapHasHitEvent();
            }
        }
    }
}
