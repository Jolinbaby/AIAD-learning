using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public static float myTimer = 0;
    public static bool isStartCounting = false;
    // Start is called before the first frame update
    void Start()
    {
        myTimer = 0;
    }
    // Update is called once per frame
    void Update()
    {
        if(isStartCounting)
        {
            myTimer += Time.deltaTime;
            int M = (int)(myTimer / 60);
            float S = myTimer % 60;
            transform.GetComponent<Text>().text= M + ":" + string.Format("{0:00}", S);
        }
    }
    public void Initialize()
    {
        float time = myTimer;
        myTimer -= time;
        isStartCounting = false;
    }
}
