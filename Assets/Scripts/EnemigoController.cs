using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoController : MonoBehaviour
{
    public float velocidad = 2f;

    private void Update() 
    {
        transform.position += Vector3.left * velocidad * Time.deltaTime;
    }
}
