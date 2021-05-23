using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//This is base class 
public class Enemy :MonoBehaviour
{
    public void Attack()
    {
        Debug.Log("Enemy Attack");
        GetComponent<Renderer>().material.color = Color.red;
    }
    /*protected void Attack()
    {
        Debug.Log("Enemy Attack");
        GetComponent<Renderer>().material.color = Color.red;
    }*/
}
