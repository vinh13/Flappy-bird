using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{

    public float upForce;
    public bool isDead = false;

    private Rigidbody2D rBody;
    private Animator anim;



    void Start()
    {
        rBody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (isDead == false)
        {
            if (Input.GetMouseButtonDown(0))
            {
                anim.SetTrigger("fly");
                rBody.velocity = Vector2.zero;
                rBody.AddForce(new Vector2(0, upForce));
            }
        }
    }


    void OnCollisionEnter2D(Collision2D other)
    {
        rBody.velocity = Vector2.zero;
        isDead = true;
        anim.SetTrigger("die");
      
       // GameControl.instance.BirdDied();
    }



}// Class
