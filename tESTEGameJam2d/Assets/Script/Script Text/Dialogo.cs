using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogo : MonoBehaviour
{
    public FalaNpc[] falas;
    public bool dialogoConcluido = false;
    DialogoController dialogocontroller;
    public string ObJETOcOLL;

    GameObject Player;
    Transform _SpritePlayer;

    private bool beGood;

    void Start()
    {
        Player = GameObject.Find("Personagem");
        dialogocontroller = FindObjectOfType<DialogoController>();
        _SpritePlayer = GameObject.Find("Capítão").GetComponent<Transform>();
    }

    void Update()
    {

        if (_SpritePlayer.transform.localScale.x == -1)
        {
            beGood = true;
        } else
        {
            beGood = false;
        }

        if (ObJETOcOLL == "Personagem")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {

                if (beGood)
                {

                    Player.GetComponent<MovimentPersonAndJump>().moveSpeed = 0;
                    dialogocontroller._diAL = this.GetComponent<Dialogo>();

                    if (!dialogoConcluido)
                    {
                        dialogocontroller.ProximaFala(falas[0]);
                    }
                    else
                    {
                        dialogocontroller.ProximaFala(falas[2]);
                    }

                }
                else
                {
                    Player.GetComponent<MovimentPersonAndJump>().moveSpeed = 0;
                    dialogocontroller._diAL = this.GetComponent<Dialogo>();

                    if (!dialogoConcluido)
                    {
                        dialogocontroller.ProximaFala(falas[1]);
                    }
                    else
                    {
                        dialogocontroller.ProximaFala(falas[2]);
                    }
                }
            }



        }


    }
    public void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("player"))
        ObJETOcOLL = other.name;

    }
    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("player"))       
            ObJETOcOLL = null;
    }

    private void LadoQuePlayerEstaOlhando()
    {

    }

 }
