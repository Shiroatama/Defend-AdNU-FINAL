using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyAttack : MonoBehaviour
{
    public int damage;
    private float passedTime = 3;
    private float attackDelay = 3;
    public Animator myanimator;
    
    // Update is called once per frame
    void Update()
    {
        if(passedTime >= attackDelay){
            passedTime = 0;
            myanimator.SetTrigger("attack");
            FindObjectOfType<playerHealth>().takePlayerDamage(damage);
        }
        if(passedTime < attackDelay){
            passedTime += Time.deltaTime;
        }
    }
}
