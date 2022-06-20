using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonagemTR_Script : MonoBehaviour
{
    [SerializeField] public float valorJump;
    [SerializeField] bool inJumping = false;
    //[SerializeField] int runVelocidade;


    private float boosterMultiplier;
    private float boosterTimer;

    private float timerControll;
    private SurfaceEffector2D effector;
    private bool boosted = false;

    float coinsAmount = 0;

    Rigidbody2D rb2d;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        effector = GameObject.Find("Pista1").GetComponent<SurfaceEffector2D>();
        effector = GameObject.Find("Pista3").GetComponent<SurfaceEffector2D>();
        effector = GameObject.Find("Pista4").GetComponent<SurfaceEffector2D>();
        effector = GameObject.Find("Pista5").GetComponent<SurfaceEffector2D>();
    }


    void Update()
    {
        // script p/ o personagem não parar de correr...
        // transform.position = Vector3.right * runVelocidade * Time.deltaTime + transform.position; 
              
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            if (inJumping == true) 
            {
                rb2d.AddForce(Vector2.up * valorJump);
                inJumping = false;
            }
        }

        if (boosted)
        {
            timerControll -= Time.deltaTime;

            if (timerControll <= 0)
            {
                effector.speed /= boosterMultiplier;
                boosted = false;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Pista")) 
        {
            if (inJumping == false) 
            {
                inJumping = true;
            }
        }
    }
    public void boost(float multiplier, float timer)
    {
        boosterMultiplier = multiplier;
        boosterTimer = timer;

        if (!boosted)
        {
            boosted = true;
            timerControll = boosterTimer;
            effector.speed *= boosterMultiplier;
        }
    }

    public void captureCoin()
    {
        coinsAmount += 1;
    }

    public float getScore()
    {
        return coinsAmount;
    }
}
