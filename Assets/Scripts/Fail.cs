using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Fail : MonoBehaviour
{
    [SerializeField] ParticleSystem crashEffect;
    [SerializeField] AudioSource failSFX;
    [SerializeField] PlayerController playerController;
    bool hasPlayed;
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Ground")
        {
            Debug.Log("Lose, Player Died!");
            Invoke("ReloadScene", 0.5f);
            if (!hasPlayed)
            {
                crashEffect.Play();
                failSFX.Play();
                hasPlayed = true;
            }
            playerController.isControlActive = false;
        }
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }

}
