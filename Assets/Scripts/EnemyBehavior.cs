using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    private float passedTime = 0;
    private float timeStop = 3;
    public Animator myanimator;

    void Update()
    {

        if(passedTime < timeStop){
            passedTime += Time.deltaTime;
            myanimator.SetTrigger("move");
        }
        if(passedTime >= timeStop){
            //stop moving horizontally
        }

    }
}
