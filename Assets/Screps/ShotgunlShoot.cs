using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShotgunShoot : MonoBehaviour
{

    public GameObject bullet;
    public Transform spawnPos1;
    public Transform spawnPos2;
    public Transform spawnPos3;
    public Transform spawnPos4;
    public Transform spawnPos5;
    public Transform spawnPos6;
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

                    if(curAnim == "idel")
                    {
                        shootSounds.Play();
                        animator.SetTrigger("Shoot");
                        Instantiate(bullet, spawnPos1.position, spawnPos1.rotation);
                        Instantiate(bullet, spawnPos2.position, spawnPos2.rotation);
                        Instantiate(bullet, spawnPos3.position, spawnPos3.rotation);
                        Instantiate(bullet, spawnPos4.position, spawnPos4.rotation);
                        Instantiate(bullet, spawnPos5.position, spawnPos5.rotation);
                        Instantiate(bullet, spawnPos6.position, spawnPos6.rotation);
                        Instantiate(effect, spawnPos1.position, spawnPos1.rotation);
                        prevShoot = Time.time;

                        currentMagazin--;
                        ammoText.text = currentMagazin.ToString() + "/" + magazineAmaunt.ToString();
                    }
                }
            }
        }
        if (Input.GetKeyDown(KeyCode.R) && currentMagazin < magazineAmaunt)
        {
            string curAnim = animator.GetCurrentAnimatorClipInfo(0)[0].clip.name;

            if  (curAnim == "idel")
            {
                animator.SetTrigger("Reload");
            }
        }
    }

    public void Rload ()
    {

        if (currentMagazin >= magazineAmaunt)
        {
            animator.SetTrigger("EndReload");
            return;
        }

        currentMagazin++;
        ammoText.text = currentMagazin.ToString() + "/" + magazineAmaunt.ToString();

        if(currentMagazin >= magazineAmaunt)
        {
            animator.SetTrigger("EndReload");
        }
    }
}
