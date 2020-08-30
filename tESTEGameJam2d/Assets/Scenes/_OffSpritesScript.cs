using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _OffSpritesScript : MonoBehaviour
{

    public GameObject _Sprite_Oceano_Frente;
    public GameObject _Sprite_Barco_Frente;
    public GameObject _Sprite_Oceano_BG;

    public _OnSpritesScript _oSS;

    private void OnTriggerEnter2D(Collider2D oth)
    {        
        if (oth.CompareTag("player"))
        {
            _Sprite_Oceano_Frente.SetActive(false);
            _Sprite_Barco_Frente.SetActive(false);
            _Sprite_Oceano_BG.SetActive(true);
        }
    }

}
