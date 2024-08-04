using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float m_loadDelay = 0.5f;
    [SerializeField] ParticleSystem m_crashEffect;
    [SerializeField] ParticleSystem m_trailEffect;

    [SerializeField] AudioSource m_crashAudio;
    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.collider.tag == "Ground")
        {
           m_trailEffect.Play();                
        }
            
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        m_trailEffect.Stop();
    } 

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Ground")
        {
            FindObjectOfType<PlayerController>().DisableControl();
            m_crashEffect.Play();
            m_crashAudio.Play();
            Invoke("ReloadScene" , m_loadDelay);
        }
    }

    private void ReloadScene()
    {
        SceneManager.LoadScene(0);  
    }
}
