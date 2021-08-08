using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ShootBtnController : MonoBehaviour
{
    public VideoRecording.RecordingSample videoRecord;
    public Button stopBtn;

    private GameObject countDownObject;
    public GameObject countDownPrefab;
    public Text timer;
    public static bool isCountDownOver = true;

    public GameObject okBtn;
    public GameObject tip;

    private bool isStart = false;
    private float duration = 3.0f;
    // Start is called before the first frame update
    void Start()
    {
        transform.GetComponent<Button>().onClick.AddListener(OnClick);

    }
    void OnClick()
    {
        if (isCountDownOver)
        {
            ///隐藏ok按钮和内容
            if (okBtn.activeInHierarchy == true)
            {
                okBtn.SetActive(false);
            }
            if (tip.activeInHierarchy == true)
            {
                tip.SetActive(false);
            }
            ///换为停止录制的按钮
            //this.gameObject.SetActive(false);
            stopBtn.gameObject.SetActive(true);

            isCountDownOver = false;
            ///倒计时显示?还是啥
            GameObject mUICanvas = GameObject.Find("Canvas");
            countDownObject = Instantiate(countDownPrefab, new Vector3(0, 0, 0), Quaternion.identity);
            countDownObject.transform.parent = mUICanvas.transform;
            countDownObject.transform.localPosition = new Vector3(0, 0, 0);
            isStart = true;
            // Invoke("record", duration);

        }

    }
    private void Update()
    {
        if (isStart)
        {
            duration -= Time.deltaTime;
        }
        if (duration <= 0)
        {
            Debug.Log("开始拍摄！！");
            ///开始录制
            videoRecord.SampleStart();

            duration = 3.0f;
            this.gameObject.SetActive(false);
            isStart = false;
        }
    }
}
