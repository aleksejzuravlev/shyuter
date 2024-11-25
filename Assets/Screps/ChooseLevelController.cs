using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChooseLevelController : MonoBehaviour
{
    
    public void LoadSene(string sceneName)
    {
        //Если SceneName = restsrt - перезагрузка
        if(sceneName == "Restart")
        {
            //Взять текущее название уровня
            string currentScene = SceneManager.GetActiveScene().name;
            //Запустить этот уровень
            SceneManager.LoadScene(currentScene);
            return;
        }
        SceneManager.LoadScene(sceneName);
    }
}
