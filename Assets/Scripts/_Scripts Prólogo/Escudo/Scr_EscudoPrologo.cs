﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_EscudoPrologo : MonoBehaviour
{
    public bool evento2;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            evento2 = true;

            gameObject.GetComponent<MeshRenderer>().enabled = false;
        }
    }
}