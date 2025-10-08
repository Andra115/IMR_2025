using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeBehaviour : MonoBehaviour
{
    public GameObject thisObject;
    public GameObject otherObject;

    public float minimumDistance = 1f;

    void Update()
    {
        float distance = Vector3.Distance(thisObject.transform.position, otherObject.transform.position);

        if (distance <= minimumDistance)
        {
            thisObject.GetComponent<Animator>().SetBool("isAttacking", true);
            Debug.Log("GET HER!");
        }
        else
        {
            thisObject.GetComponent<Animator>().SetBool("isAttacking", false);
            Debug.Log("Chill...");
        }
    }
}