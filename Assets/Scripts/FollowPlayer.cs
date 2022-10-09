//Castañeda Rivera Oscar David
//GDGS2101

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    //Se crea  un objeto llamado player
    public GameObject player;
    //Variable que indicará la posición de donde se encontrará la cámara
    private Vector3 offset = new Vector3(0,9,-20);

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void LateUpdate() 
    {
        /*Se indica que la camara se va desplazar detrás del jugador (vehículo)
         comenzando a partir de la posición establecida al inicio
        */
        transform.position = player.transform.position + offset;
    }
}
