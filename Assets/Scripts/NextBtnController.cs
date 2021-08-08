using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NextBtnController : MonoBehaviour
{
    public GameObject recordFBX01;
    public GameObject recordFBX02;
    public GameObject recordFBX03;
    public GameObject nextBtn;
    public GameObject restartBtn;
    public GameObject recordBtn;
    public GameObject timer;
    public GameObject tip;
    public GameObject okBtn;
    
    public static int times = 0;//点击次数

    // Start is called before the first frame update
    void Start()
    {
        //点击下一步
        nextBtn.GetComponent<Button>().onClick.AddListener(delegate ()
        {
            nextBtn.SetActive(false);
            restartBtn.SetActive(false);
            //显示拍摄按钮
            recordBtn.SetActive(true);
            times++;
            //显示提示文字和ok按钮
            tip.SetActive(true);
            okBtn.SetActive(true);

            if (times % 3 == 1)
            {
                recordFBX01.SetActive(false);
                recordFBX02.SetActive(true);
                Animation animation02 = recordFBX02.GetComponent<Animation>();
                animation02.Play();
            }
            else if (times % 3 == 2)
            {
                recordFBX02.SetActive(false);
                recordFBX03.SetActive(true);
                Animation animation03 = recordFBX03.GetComponent<Animation>();
                animation03.Play();
            }
            else if (times % 3 == 0)
            {
                recordFBX03.SetActive(false);
                recordFBX01.SetActive(true);
                Animation animation01 = recordFBX01.GetComponent<Animation>();
                animation01.Play();
            }
        });
        //点击重新拍摄
        restartBtn.GetComponent<Button>().onClick.AddListener(delegate ()
        {
            nextBtn.SetActive(false);
            restartBtn.SetActive(false);
            //计时消失
            timer.SetActive(false);
            Timer.myTimer = 0;
            //显示拍摄按钮
            recordBtn.SetActive(true);
           
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
