using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowEffect : MonoBehaviour
{

    [SerializeField] ParticleSystem snowEffect;



    public void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag=="Ground")
        {
            snowEffect.Play();
        }
    }

    public void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.tag == "Ground")
        {
            snowEffect.Stop();
        }
    }
}
