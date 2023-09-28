using BasicCode;
using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class 怪物死亡數 : MonoBehaviour
{
    //List<EnemyHealth> enemyHealth;
    //private EnemyHealth enemyHealth;
    private PlayerHealth playerHealth;

    private Animator animator;
    private int 開門;
    int 目前Dead數量 = 0;
    private GameObject[] enemyHealth;

    void Start()
    {
        enemyHealth = GameObject.FindGameObjectsWithTag("Enemy");
        //enemyHealth = GameObject.FindWithTag("Enemy").GetComponent<EnemyHealth>();
        foreach (GameObject enemy in enemyHealth)
        {
            enemy.GetComponent<EnemyHealth>().DeadReceived += OnDead; 
        }

        playerHealth = GameObject.FindWithTag("Player").GetComponent<PlayerHealth>();
        playerHealth.RevivalReceived += RevivalReceived;





        animator = GetComponentInChildren<Animator>();
    }

    private void RevivalReceived(object sender, EventArgs e)
    {
        animator.SetTrigger("關門");
        目前Dead數量 = 0;
    }

    private void OnDead(object sender, EventArgs e)
    {
        目前Dead數量++;
        print(目前Dead數量);
        if (目前Dead數量 >= 5)
        {
            animator.SetTrigger("開門");
        }
    }


}
