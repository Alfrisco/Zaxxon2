using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{


    //Posición de la nave para mover la cámara
    [SerializeField] Transform playerPosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Con este código, la cámara seguirá al jugador, pero alejado algo en el eje Z
        transform.position = new Vector3(playerPosition.position.x, playerPosition.position.y, playerPosition.position.z - 5);

    }
}
