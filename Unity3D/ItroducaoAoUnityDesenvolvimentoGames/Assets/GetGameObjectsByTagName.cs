using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetGameObjectsByTagName : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject[] objects = GameObject.FindGameObjectsWithTag("Cube");

        foreach (var o in objects)
        {
            print(o);
        }
    }
}
