using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentPersonAndJump : MonoBehaviour
{
    public float moveSpeed = 5f;

    public InteracaoScript a;

    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        jUMP();


        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += movement * Time.deltaTime * moveSpeed;
    }

    public void jUMP()
    {

        if (Input.GetKey(KeyCode.E) && a.subindoEscada == true)
        {


            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, 5f), ForceMode2D.Impulse);
            if (gameObject.GetComponent<Rigidbody2D>().velocity.y >= 10)
            {
                gameObject.GetComponent<Rigidbody2D>().velocity = new Vector3(0, 10, 0);
            }



        }






    }
}




