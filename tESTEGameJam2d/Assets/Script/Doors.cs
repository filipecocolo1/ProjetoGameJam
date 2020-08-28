using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doors : MonoBehaviour
{
    public Transform _PortaDestino;
    public GameObject Player;
    public string _ObjetoColidindoComigo;

    private void Update()
    {
        if (_ObjetoColidindoComigo == "Personagem" && Input.GetKeyDown(KeyCode.E))
        {
            Player.transform.position = new Vector3(_PortaDestino.transform.position.x, _PortaDestino.transform.position.y, 0);
        }
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "player")
        {
            _ObjetoColidindoComigo = other.name;
        }
    }


    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "player")
        {
            _ObjetoColidindoComigo = null;
        }
    }

}
