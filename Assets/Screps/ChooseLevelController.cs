using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChooseLevelController : MonoBehaviour
{
    
    public void LoadSene(string sceneName)
    {
        //���� SceneName = restsrt - ������������
        if(sceneName == "Restart")
        {
            //����� ������� �������� ������
            string currentScene = SceneManager.GetActiveScene().name;
            //��������� ���� �������
            SceneManager.LoadScene(currentScene);
            return;
        }
        SceneManager.LoadScene(sceneName);
    }
}
