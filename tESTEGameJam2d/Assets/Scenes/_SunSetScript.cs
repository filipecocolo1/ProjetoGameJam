using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _SunSetScript : MonoBehaviour
{

    public GameObject DaySky;
    public GameObject MidDaySky;
    public GameObject LateDaySky;
    public GameObject NightSky;

    public GameObject _CameraFog;

    public float _tempo;

    private void Update()
    {

        _tempo += Time.deltaTime;

        //if (_tempo > 6) 
        //{
        //    LateDaySky.SetActive(false);
        //}
        //else if (_tempo > 4) 
        //{
        //    MidDaySky.SetActive(false);
        //}
        //else if (_tempo > 2) 
        //{
        //    DaySky.SetActive(false);
        //}
    }

}
