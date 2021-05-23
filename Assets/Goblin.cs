using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//This is derived class
public class Goblin : MonoBehaviour
{
    private void Start()
    {
        Goblin myGoblin = new Goblin();
        myGoblin.Attack();
        Goblin redgoblin = new RedGoblin();
        redgoblin.Attack();
        Goblin whitegoblin = new WhiteGoblin();
        whitegoblin.Attack();

    }
    public virtual void Attack()
    {
        Debug.Log("Goblin Attack");
    }
}
public class RedGoblin:Goblin
{
    public override void Attack()
    {
        Debug.Log("Redgoblin Attack");
    }
}
public class WhiteGoblin : Goblin
{
    public override void Attack()
    {
        Debug.Log("Whitegoblin Attack");
    }
}
