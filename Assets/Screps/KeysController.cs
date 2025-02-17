using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class KeysController : MonoBehaviour
{
    int keysAll = 5;
    int keysCount = 0;
    public Text keysText;
    public TextMeshProUGUI doorText;
    public GameObject cutSceneTrigger;
    public void TakeKey()
    {
        print("найден ключ");
        keysCount++;
        keysText.text = keysCount.ToString() + "/" + keysAll.ToString();
        //чтоб не читерели

        if (keysCount == keysAll)
        {
            doorText.text = "Открыто!";
            cutSceneTrigger.SetActive(true);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
