using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PIstolShoot : MonoBehaviour
{

    public GameObject bullet;
    public Transform spawnPos;
    public GameObject effect;
    private Animator animator;
    public AudioSource shootSounds;
    public float timeShoot = 1;
    private float prevShoot = -100;
    public int magazineAmaunt = 20;
    public int currentMagazin = 20;
    public Text ammoText;
        // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        currentMagazin = magazineAmaunt;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            float currentTime = Time.time;
            if(currentTime - prevShoot > timeShoot)
            {
                if(currentMagazin > 0)
                {
                    string curAnim = animator.GetCurrentAnimatorClipInfo(0)[0].clip.name;
                    if(curAnim == "Idel")
                    {
                        shootSounds.Play();
                        animator.SetTrigger("Shoot");
                        Instantiate(bullet, spawnPos.position, spawnPos.rotation);
                        Instantiate(effect, spawnPos.position, spawnPos.rotation);
                        prevShoot = Time.time;

                        currentMagazin--;
                        ammoText.text = currentMagazin.ToString() + "/" + magazineAmaunt.ToString();
                    }
                }
            }
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            animator.SetTrigger("Reload");
        }
    }

    public void Rload ()
    {
        currentMagazin = magazineAmaunt;
        ammoText.text = currentMagazin.ToString() + "/" + magazineAmaunt.ToString();
    }
}
