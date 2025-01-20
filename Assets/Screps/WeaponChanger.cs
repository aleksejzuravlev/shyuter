using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponChanger : MonoBehaviour
{

    public GameObject pistol;
    public GameObject shotGun;
    public GameObject grenade;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            shotGun.SetActive(true);
            pistol.SetActive(false);
            if(grenade != null) grenade.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            shotGun.SetActive(false);
            pistol.SetActive(true);
            if (grenade != null) grenade.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            if (grenade == null) return;
            shotGun.SetActive(false);
            pistol.SetActive(false);
            grenade.SetActive(true);
        }
    }
}
