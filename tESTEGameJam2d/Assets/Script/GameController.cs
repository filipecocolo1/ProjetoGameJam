using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameController : MonoBehaviour
{
    public float cronometro;
    public int seg;
    public int min;
    public int dia;
    public string cena;
    // Start is called before the first frame update
    void Start()
    {

        PlayerPrefs.SetInt("Dia", dia);
    }

    // Update is called once per frame
    void Update()
    {
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


            PlayerPrefs.SetInt("Dia", PlayerPrefs.GetInt("Dia") + 1); 
            SceneManager.LoadScene(cena);
           
          

        
        
        }

    }

}







