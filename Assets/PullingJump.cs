using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PullingJump : MonoBehaviour
{


    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb=GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //rb.AddForce(rb.velocity);���R�ȓ����ɂȂ邯�ǃQ�[�����ċC�ɂ��������Ȃ�\��������
            rb.velocity = Vector3.up*10;
        }


    }
}
