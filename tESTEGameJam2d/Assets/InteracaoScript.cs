using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteracaoScript : MonoBehaviour
{
    public bool subindoEscada = false;
    public bool EsbarrouNpc = false;

  


    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
       
     
    
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Escada")
        {
            subindoEscada = true;
        }

        if (collision.tag == "Npc") {

            EsbarrouNpc = true;





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







    }


}
