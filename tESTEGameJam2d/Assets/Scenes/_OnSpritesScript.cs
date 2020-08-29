using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _OnSpritesScript : MonoBehaviour
{

    public GameObject _Sprite_Oceano_Frente;
    public GameObject _Sprite_Barco_Frente;
    public GameObject _Sprite_Oceano_BG;

    private void OnTriggerEnter2D(Collider2D oth)
    {        
        if (oth.CompareTag("player"))
        {
            _Sprite_Oceano_Frente.SetActive(true);
            _Sprite_Barco_Frente.SetActive(true);
            _Sprite_Oceano_BG.SetActive(false);
        }
    }
}
