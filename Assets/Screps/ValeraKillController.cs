using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ValeraKillController : MonoBehaviour
{

    public Text killText;
    public Text recordText;
    private int kills;
    private int record;
    // Start is called before the first frame update
    void Start()
    {
        kills = 0;
        record = PlayerPrefs.GetInt("Record", 0);
        recordText.text = "Рекорд:  " + record.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void KillValera()
    {
        kills++;
        killText.text = "Убито:  " + kills.ToString();

        if (kills > record)
        {
            record = kills;
            recordText.text = "Рекорд:  " + record.ToString();
            PlayerPrefs.SetInt("Record", record); 
            print(123);
        }
    }
}
