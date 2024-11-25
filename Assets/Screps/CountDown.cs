using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class CountDown : MonoBehaviour
{

    public int seconds = 5;
    int currentTime;
    public Text timerText;
    public GameObject player;
    public GameObject winPanel;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Timer");
        currentTime = seconds;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Timer()
    {
        while (true)
        {
            timerText.text = (currentTime / 60).ToString() + ":" + currentTime % 60;
            currentTime--;
            if (currentTime <= 0)
            {
                //player.SetActive(false);
                //winPanel.SetActive(true);
                yield break;
            }
            yield return new WaitForSeconds(1);
        }
    }
}
