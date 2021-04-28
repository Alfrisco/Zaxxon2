using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour
{
    [SerializeField] GameObject SphereObject;
    private SphereScript sphereScript;
    

    // Start is called before the first frame update
    void Start()
    {
        sphereScript = SphereObject.GetComponent<SphereScript>();

        print(sphereScript.speed);
        sphereScript.SendMessage("mandaraConsola");
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(Vector3.up * Time.deltaTime * sphereScript.speed);
    }
}
