using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score_Script : MonoBehaviour
{
    public TMP_Text textScore;
    private PersonagemTR_Script _player;

    void Start()
    {
        _player = GameObject.Find("Personagem_TR").GetComponent<PersonagemTR_Script>();
    }

    void Update()
    {
        textScore.text = _player.getScore().ToString() + "";
    }
}