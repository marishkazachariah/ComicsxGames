using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiatePills : MonoBehaviour
{
    public GameObject smileyPill;
    public GameObject regularPill;
    public GameObject[] happypillAmount;
    public GameObject[] regularpillAmount;
    public float radius = 0.5f;

    public Collider something;

    //public void GetPills()
    void Awake()
    {
        happypillAmount = new GameObject[3];
        for (int i = 0; i < happypillAmount.Length; i++)
        {
            GameObject happyPillClone = Instantiate(smileyPill, Random.insideUnitSphere * radius + transform.position, Random.rotation);
            happypillAmount[i] = happyPillClone;
        }

        regularpillAmount = new GameObject[3];
        for (int i = 0; i < regularpillAmount.Length; i++)
        {
            GameObject regularPillClone = Instantiate(regularPill, Random.insideUnitSphere * radius + transform.position, Random.rotation);
            regularpillAmount[i] = regularPillClone;
        }
    }
    public void GetMorePills()
    {
        happypillAmount = new GameObject[1];
        for (int i = 0; i < happypillAmount.Length; i++)
        {
            GameObject happyPillClone = Instantiate(smileyPill, Random.insideUnitSphere * radius + transform.position, Random.rotation);
            happypillAmount[i] = happyPillClone;
        }

        regularpillAmount = new GameObject[1];
        for (int i = 0; i < regularpillAmount.Length; i++)
        {
            GameObject regularPillClone = Instantiate(regularPill, Random.insideUnitSphere * radius + transform.position, Random.rotation);
            regularpillAmount[i] = regularPillClone;
        }
    }
}
    //Instantiate(smileyPill[5], Random.insideUnitSphere * radius + transform.position, Random.rotation);
