using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TraiwyndFighterController : MonoBehaviour
{
    public GameObject laserBeam;
    private bool allowAttack;
    Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        allowAttack = true;
        offset = new Vector3(0, 0, -15);
    }

    // Update is called once per frame
    void Update()
    {
        Attack();
    }

    void Attack()
    {
        if (allowAttack)
        {
            GameObject.Instantiate(laserBeam, transform.position + offset, transform.rotation);
            allowAttack = false;
            StartCoroutine(AttackCoolDown());
        }
    }

    IEnumerator AttackCoolDown()
    {
        yield return new WaitForSeconds(Random.Range(1,1.5f));
        allowAttack = true;
    }
}
