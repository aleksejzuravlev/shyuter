using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GrenadeeController : MonoBehaviour
{
    public GameObject from;
    public GameObject grenade;
    public float strength = 2;

    public int grenadeCount = 5;
    public Text grenadeText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Awake()
    {
        grenadeText.text = grenadeCount.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0) && grenadeCount > 0)
        {
            GameObject newGrenade = Instantiate(grenade, from.transform.position,from.transform.rotation);
            Rigidbody grenadeRB = newGrenade.GetComponent<Rigidbody>();
            grenadeRB.AddForce(from.transform.forward * strength,ForceMode.Impulse);

            grenadeCount--;
            grenadeText.text = grenadeCount.ToString();
        }
    }
}
