using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ITrap
{
    void Activate();
    void Reset();
}

public class PushTrap : MonoBehaviour, ITrap
{
    [SerializeField]
    private PlayerController m_player;
    
    Animator m_animator;

    void Start()
    {
        m_player.TrapHasHitEvent += Reset;

        m_animator = GetComponent<Animator>();

        m_animator.SetInteger("State", 0);
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

}
