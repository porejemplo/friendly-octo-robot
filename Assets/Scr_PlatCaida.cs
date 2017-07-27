﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_PlatCaida : MonoBehaviour
{
    [SerializeField]
    GameObject destruir1;

    [SerializeField]
    GameObject destruir2;

    [SerializeField]
    GameObject destruir3;

    [SerializeField]
    int tiempo;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(destruir1, tiempo);
            Destroy(destruir2, tiempo);
            Destroy(destruir3, tiempo);
        }
    }
}