using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTest : MonoBehaviour

{
    // Start is called before the first frame update
    void Start()
    {
        Enemy myEnemy = new Enemy();
         myEnemy.Attack();
        //protected cant access
       // myEnemy.Attack();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}