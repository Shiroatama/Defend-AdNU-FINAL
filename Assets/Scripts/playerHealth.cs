using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerHealth : MonoBehaviour
{
    
    public int userHealth = 5;
    
    // Start is called before the first frame update
    void Start()
    {
        userHealth = 5;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void takePlayerDamage(int amount){
            userHealth -= amount;
            if(userHealth == 0){
                //game over
            }

        }
}
