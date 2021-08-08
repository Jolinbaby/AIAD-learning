using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TipController : MonoBehaviour
{
    //public float displayTime = 2.0f;
    private GameObject okButton;
    private GameObject tip;
    // Start is called before the first frame update
    void Start()
    {
        GameObject UIcanvas = GameObject.Find("TargetCanvas");
        tip = UIcanvas.transform.Find("Tip").gameObject;
        okButton= UIcanvas.transform.Find("okButton").gameObject;
        okButton.GetComponent<Button>().onClick.AddListener(Click);
    }

    // Update is called once per frame
    void Update()
    {
        /*
        displayTime -= Time.deltaTime;
        if (displayTime <= 0)
        {
            tip.SetActive(false);
            Destroy(this.gameObject);
        }
        */
    }
    void Click()
    {
        tip.SetActive(false);
        okButton.SetActive(false);
    }
}
