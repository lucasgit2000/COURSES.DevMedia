using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoEnquantoApertaBotao : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            transform.Translate(Vector3.right);
        }
        
    }
}
