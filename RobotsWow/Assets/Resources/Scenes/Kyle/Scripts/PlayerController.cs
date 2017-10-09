using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public delegate void OnTrapHit();

public class PlayerController : MonoBehaviour
{
    //public event OnTrapHit TrapHasHitEvent;

    [SerializeField]
    Transform m_spawnpoint;

    void Start()
    {
        Reset();

        //TrapHasHitEvent += Reset;
    }

    void Reset()
    {
        transform.position = m_spawnpoint.position;
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Trap"))
        {
            Debug.Log("IK BEN GERAAKT!!!");
            other.gameObject.GetComponentInParent<Trap>().Reset();

            /*
            if (TrapHasHitEvent != null)
            {
                TrapHasHitEvent();
            }
            */

            Reset();
        }
    }
}
