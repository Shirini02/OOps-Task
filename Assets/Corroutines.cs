using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Corroutines : MonoBehaviour
{
    // Start is called before the first frame update
    /* int num = 0;
    // IEnumerator coritine;
     void Start()
     {
         // coritine = ScoreUpdate();
         print("Start");
         StartCoroutine(ScoreUpdate());

         //ScoreUpdate();
     }

     // Update is called once per frame
     private void Update()
     {
      //   StartCoroutine(ScoreUpdate());

     }
     IEnumerator ScoreUpdate()
     {
         print("Score" + ++num);
         yield return new WaitForSeconds(5.0f);
         print("End");
     }
   */
    private void Awake()
    {
        
    }
    private void Start()
    {
        // StartCoroutine(ColorTest());
        StartCoroutine("ColorTest");
        ColorsTest();
    }
    IEnumerator ColorTest()
    {
        print("Start of Coroutine");
        yield return new WaitForSeconds(2.0f);
        GetComponent<Renderer>().material.color = Color.red;
        yield return new WaitForSeconds(2.0f);
        GetComponent<Renderer>().material.color = Color.green;
        yield return null;//wait for end of frame
        print("End of Coroutine");
    }
    void ColorsTest()
    {
        print("Start of normal function");
    }
   
}
