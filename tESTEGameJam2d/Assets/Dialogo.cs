using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogo : MonoBehaviour
{
    public FalaNpc[] falas = new FalaNpc[2];
    private bool dialogoConcluido = false;
    DialogoController dialogocontroller;
    public string ObJETOcOLL;
    // Start is called before the first frame update
    void Start()
    {
        dialogocontroller = FindObjectOfType<DialogoController>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("player"))
        {
            ObJETOcOLL = other.name;
            if (Input.GetKeyDown(KeyCode.E))
            {

                other.GetComponent<MovimentPersonAndJump>().moveSpeed = 0;



                if (!dialogoConcluido)
                {
                    dialogocontroller.ProximaFala(falas[0]);


                }
                else
                {

                    dialogocontroller.ProximaFala(falas[1]);

                }
                dialogoConcluido = true;

            }

        }
    }
    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("player"))
        {
            ObJETOcOLL = null;
        }

    }
 }
