using BasicCode;
using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class 推 : MonoBehaviour
{
    [SerializeField]
    private Animator animator;
    private GameManager_Basic gameManager;
    private float timer;
    private bool 可計時=false;

    void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager_Basic>();
    }
    private void Update()
    {
        if (可計時)
        {
            timer += Time.deltaTime;
            if (timer > 4)
            {
                gameManager.GameOver();
                可計時 = false;
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            animator.SetTrigger("關門");
            animator.SetTrigger("推人");
            可計時 = true;

        }
    }
}
