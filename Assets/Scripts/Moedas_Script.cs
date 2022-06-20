using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moedas_Script : MonoBehaviour
{
    private PersonagemTR_Script _player;
    private bool active = true;

    void Start()
    {
        _player = GameObject.Find("Personagem_TR").GetComponent<PersonagemTR_Script>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && active)
        {
            _player.captureCoin();
            active = false;

            Destroy(gameObject);
        }
    }

}