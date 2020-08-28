using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerButton : MonoBehaviour
{
    Resposta respostaData;

    public void ProximaFala() {
        FindObjectOfType<DialogoController>().ProximaFala(respostaData.proximafala);    
    }

    public void Setup(Resposta resposta) {
        respostaData = resposta;    
    }
}
