using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ValeraSpawner : MonoBehaviour
{
    public GameObject valera;
    public GameObject valeraConus;
    public GameObject valeraGuga;
    public GameObject valeraArmor;
    public GameObject valeraMag1;
    public GameObject valeramag3;
    public float radius;
    public float second;
    public int count;

    private void Spaw()
    {
        Vector3 point = Random.insideUnitSphere * radius;
        point += transform.position;

        NavMeshHit hit;
        NavMesh.SamplePosition(point, out hit, radius, 1);
        Vector3 finalPos = hit.position;

        //�������� �� �������������
        if(finalPos.x == float.PositiveInfinity || 
        finalPos.y == float.PositiveInfinity || 
        finalPos.z == float.PositiveInfinity)
        {
            print("������������� �� ������");
            return;
        }

        int chance = Random.Range(0, 100);
        if (chance < 15)
        {
            Instantiate(valeraConus, finalPos, Quaternion.identity);
        }
        else if (chance < 65)
        {
            Instantiate(valera, finalPos, Quaternion.identity);
        }
        else if (chance < 70)
        {
            Instantiate(valeraGuga, finalPos, Quaternion.identity);
        }
        else if (chance < 75)
        {
            Instantiate(valeraArmor, finalPos, Quaternion.identity);
        }
        else if (chance < 80)
        {
            Instantiate(valeraMag1, finalPos, Quaternion.identity);
        }
        else if (chance < 85)
        {
            Instantiate(valeramag3, finalPos, Quaternion.identity);
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(transform.position, radius);
    }

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Timer");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.G)) 
        {
            Spaw();
        }
    }

    IEnumerator Timer()
    {
        while(true)
        {
            for(int i = 0; i < count; i++)
            {
                Spaw();
            }
            yield return new WaitForSeconds(second);
        }
    }
}
