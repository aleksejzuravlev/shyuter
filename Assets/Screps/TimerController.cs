using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerController : MonoBehaviour
{

    private int t = 0;
    public Text timerText;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Timer");
    }


    IEnumerator Timer()
    {
        while (true)
        {
            t++;
            timerText.text = (t / 60).ToString() + ":" + (t % 60).ToString();
            yield return new WaitForSeconds(1);
        }
    }
}
