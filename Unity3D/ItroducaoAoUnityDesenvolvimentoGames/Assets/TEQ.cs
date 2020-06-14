using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TEQ : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        // // rotaciona visao para frente do go(game object)
        // transform.rotation = Quaternion.LookRotation(Vector3.forward);

        // // rotaciona visao para frente do go(game object) suavemente usando o QUARTENION(somente ele é possível com o slerp)
        // var rotationFowardVision = Quaternion.LookRotation(Vector3.forward);
        // transform.rotation = Quaternion.Slerp(transform.rotation, rotationFowardVision, Time.deltaTime);

        //ou podemos rotacionar assim:
        transform.LookAt(Vector3.forward);
    }
}
