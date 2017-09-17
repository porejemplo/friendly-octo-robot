﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Scr_PlayerDeath : MonoBehaviour
{
    GameObject Aura;

    Vector3 checkpoint;

    private void Start()
    {
        Aura = GameObject.Find("Aura");

        DontDestroyOnLoad(Aura);
    }

    private void Update()
    {
        checkpoint = Scr_PlayerCheckpoint.checkpoint;

        Debug.Log("Last checkpoint position: " + checkpoint);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Death();
        }
    }

    void Death()
    {
        SceneManager.LoadScene("Scn_PruebaVictor", LoadSceneMode.Single);

        Aura.transform.position = checkpoint;
    }
}