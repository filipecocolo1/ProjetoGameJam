using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogoController : MonoBehaviour
{
    public GameObject paineldEDialogo;
    public Text FalaNpc;
    public GameObject respostas;
    public bool falaAtiva = false;
    FalaNpc falas;
    [HideInInspector]
    public Dialogo _diAL;

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && falaAtiva == true) {

            if (falas.respostas.Length > 0)
            {
                MostrarResposta();
            }
            else {

                _diAL.dialogoConcluido = true;
                falaAtiva = false;
                paineldEDialogo.SetActive(false);
                FalaNpc.gameObject.SetActive(false);
                FindObjectOfType<MovimentPersonAndJump>().moveSpeed = 5;

            }
        
        }
    
    
    }
    void MostrarResposta() {
        FalaNpc.gameObject.SetActive(false);
        falaAtiva = false;
        for (int i = 0; i < falas.respostas.Length; i++)
        {
            GameObject tempResposta = Instantiate(respostas, paineldEDialogo.transform) as GameObject;
            tempResposta.GetComponent<Text>().text = falas.respostas[i].resposta;
            tempResposta.GetComponent<AnswerButton>().Setup(falas.respostas[i]);
        
        
        }
    
    
    }
    public void ProximaFala(FalaNpc fala) {

        falas = fala;
        LimparRespostas();
        falaAtiva = true;
        paineldEDialogo.SetActive(true);
        FalaNpc.gameObject.SetActive(true);
        FalaNpc.text = falas.fala; 
    
    }

    void LimparRespostas() {

        AnswerButton[] buttons = FindObjectsOfType<AnswerButton>();
        foreach (AnswerButton button in buttons)
        {
            Destroy(button.gameObject);
        }
    
    
    }
}