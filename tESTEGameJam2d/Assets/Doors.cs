using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doors : MonoBehaviour
{
   public GameObject Porta, player;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "player")
        {
            Debug.Log("Estou collidindo com uma porta");
            player.transform.position = new Vector3(Porta.transform.position.x -2, Porta.transform.position.y, Porta.transform.position.z);
        }
    }
    }
