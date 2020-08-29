using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _CapAnimationsTriggerScript : MonoBehaviour
{

    public Animator _anim;
    private MovimentPersonAndJump _mPAD;

    void Start()
    {
        _mPAD = GetComponent<MovimentPersonAndJump>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            _anim.transform.localScale = new Vector3(1, 1, 1);

        }else if (Input.GetKeyDown(KeyCode.A))
        {
            _anim.transform.localScale = new Vector3(-1, 1, 1);
        }

        if (_mPAD.movement.normalized.magnitude != 0)
        {
            _anim.SetBool("Andando", true);
        }
        else
        {
            _anim.SetBool("Andando", false);
        }
    }
}
