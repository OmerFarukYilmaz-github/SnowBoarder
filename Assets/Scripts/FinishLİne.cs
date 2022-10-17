using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLİne : MonoBehaviour
{
    [SerializeField] ParticleSystem finishEffect;
    [SerializeField] AudioSource finishSFX;
    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag=="Player")
        {
            Debug.Log("WIN!");
            Invoke("ReloadScene", 1f);
            finishEffect.Play();
            finishSFX.Play();
        }
    }
    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
