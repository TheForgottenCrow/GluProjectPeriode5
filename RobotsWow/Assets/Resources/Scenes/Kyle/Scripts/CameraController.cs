using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]
    GameObject m_followtarget;

    private Vector3 m_target_position;

    [SerializeField]
    float m_followspeed;

    private static bool m_doescameraexist;

	void Start ()
    {
        if (!m_doescameraexist)
        {
            m_doescameraexist = true;
            DontDestroyOnLoad(transform.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
	
	void Update ()
    {
        m_target_position = new Vector3(m_followtarget.transform.position.x, transform.position.y, transform.position.z);
        transform.position = Vector3.Lerp(transform.position, m_target_position, m_followspeed * Time.deltaTime);
	}
}
