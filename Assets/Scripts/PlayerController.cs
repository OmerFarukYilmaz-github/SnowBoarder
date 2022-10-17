using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
     Rigidbody2D rb2D;
    [SerializeField] float torqueForce=1f;
    [SerializeField] float boostSpeed = 40f;
    [SerializeField] float baseSpeed = 25f;
    SurfaceEffector2D surfaceEffector;
    public bool isControlActive = true;

    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        surfaceEffector = FindObjectOfType<SurfaceEffector2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isControlActive)
        {
            // DÖNÜÞLER
            if (Input.GetKey(KeyCode.A))
            {
                rb2D.AddTorque(torqueForce);
            }
            // else eklendi ki ikisine ayný anda basýlmasýn
            else if (Input.GetKey(KeyCode.D))
            {
                rb2D.AddTorque(-torqueForce);
            }

            //Boost
            if (Input.GetKey(KeyCode.W))
            {
                surfaceEffector.speed = boostSpeed;
            }
            else
            {
                surfaceEffector.speed = baseSpeed;
            }

        }

    }



}
