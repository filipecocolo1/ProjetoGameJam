using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteracaoScript : MonoBehaviour
{
    public bool subindoEscada = false;
    public bool EsbarrouNpc = false;
    public bool Pegouitem = false;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Escada")
        {
            subindoEscada = true;
        }

        if (collision.tag == "Npc") {

            EsbarrouNpc = true;

        }
        if (collision.tag == "Item"){

            Pegouitem = true;
            Debug.Log("Pegou Item para tal Npc");
     
        }

    
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Escada")
        {
            subindoEscada = false;
        }

        if (collision.tag == "Npc")
        {

            EsbarrouNpc = false;

        }
        if (collision.tag == "Npc")
        {
            Pegouitem = false;
            Debug.Log("Entregou  Item para tal Npc");


        }



    }  
}
