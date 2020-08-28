using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameController : MonoBehaviour
{
     public float cronometro;
        public  int seg;
    public int min;
    public int dia;
    public Animator animator;
 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Relogio();



    }



    public void Relogio() {

        cronometro += Time.deltaTime;

        if (cronometro >= 4)
        {

            seg++;
            cronometro = 0;

        }

        if (seg == 5)
        {
            min += 10;

            seg = 0;

        }

        if (min == 60)
        {

            dia++;
            min = 0;


        }

      




    }
    public void LoadScene(string scena)
    {



        if (dia >= 1)
        {
            SceneManager.LoadScene(scena);




        }

    }
    public void PlayGame()
    {
        animator.SetTrigger("Main");

    }
       
}







