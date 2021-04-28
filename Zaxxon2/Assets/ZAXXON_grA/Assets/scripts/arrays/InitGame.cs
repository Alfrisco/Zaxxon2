using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitGame : MonoBehaviour
{

    [SerializeField] GameObject[] objetos;

    Vector3 initPos = new Vector3(-21,0,21);

    void Start()
    {
        //int r = Random.Range(0, objetos.Length);
        Instantiate(objetos[1], initPos, Quaternion.Euler(-90,90,0));
        
    }

}
