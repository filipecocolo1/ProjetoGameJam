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

    void Start()
    {
        Player = GameObject.Find("Personagem");
        dialogocontroller = FindObjectOfType<DialogoController>();
    }

    void Update()
    {
        if (ObJETOcOLL == "Personagem")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {

                Player.GetComponent<MovimentPersonAndJump>().moveSpeed = 0;
                dialogocontroller._diAL = this.GetComponent<Dialogo>();

                if (!dialogoConcluido)
                {
                    dialogocontroller.ProximaFala(falas[0]);
                }
                else
                {
                    dialogocontroller.ProximaFala(falas[1]);
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
 }
