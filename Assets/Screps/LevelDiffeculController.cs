using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelDiffeculController : MonoBehaviour
{
    public ValeraSpawner Spawner;
    // Start is called before the first frame update
    void Start()
    {
        string diff = PlayerPrefs.GetString("Diff");
        if(diff == "Eassy")
        {
            Spawner.second = 10;
            Spawner.count = 1;
        }
        else if(diff == "Normal")
        {
            Spawner.second = 10;
            Spawner.count = 3;
        }
        else if(diff == "Hard")
        {
            Spawner.second = 10;
            Spawner.count = 5;
        }
        print("Сложность: " + diff);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
