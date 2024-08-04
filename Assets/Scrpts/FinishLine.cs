using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{

    [SerializeField] float m_loadDelay = 1.0f;
    [SerializeField] ParticleSystem m_finishEffect;
    [SerializeField] AudioSource m_finishAudio;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            m_finishEffect.Play();
            m_finishAudio.Play();
            Invoke("ReloadScene",m_loadDelay);
        }
            
    }

    private void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
