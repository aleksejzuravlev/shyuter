using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DifficultyController : MonoBehaviour
{
    public Toggle eassy;
    public Toggle normal;
    public Toggle hard;

    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetString("Diff", "Eassy");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateDifficult()
    {
        if (eassy.isOn)
        {
            PlayerPrefs.SetString("Diff", "Eassy");
        }
        else if (normal.isOn)
        {
            PlayerPrefs.SetString("Diff", "Normal");
        }
        else if (hard.isOn)
        {
            PlayerPrefs.SetString("Diff", "Hard");
        }
    }
}
