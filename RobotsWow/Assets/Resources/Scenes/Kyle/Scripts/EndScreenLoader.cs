using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScreenLoader : MonoBehaviour
{
    UI m_ui;

    void Start()
    {
        m_ui = GameObject.FindObjectOfType<UI>();    
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            m_ui.SetSchrempies(5);
        }
    }
}
