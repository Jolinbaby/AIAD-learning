using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDownController : MonoBehaviour
{
    public VideoRecording.RecordingSample videoRecord;
    public float countDownTime = 4.3f;
    public GameObject timer;
    // Start is called before the first frame update
    void Start()
    {
        GameObject UIcanvas = GameObject.Find("Canvas");
        timer = UIcanvas.transform.Find("Timer").gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        countDownTime -= Time.deltaTime;
        transform.GetComponent<Text>().text = ((int)countDownTime).ToString();
        if(countDownTime<=1)
        {
           
            timer.SetActive(true);
            Timer.isStartCounting = true;
            ShootBtnController.isCountDownOver = true;
            Destroy(this.gameObject);
        }
    }
}
