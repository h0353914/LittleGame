﻿using BasicCode;
using UnityEngine;

public class EndPoint_Basic : MonoBehaviour
{
    private GameManager_Basic gameManager;
    void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager_Basic>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            gameManager.GameOver();
            Destroy(gameObject);
        }
    }
}
