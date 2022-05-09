using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TraiwyndFighterController : MonoBehaviour
{
    public GameObject laserBeam;
    private bool allowAttack;

    // Start is called before the first frame update
    void Start()
    {
        allowAttack = true;
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
            GameObject.Instantiate(laserBeam, this.transform.position, this.transform.rotation);
            allowAttack = false;
            StartCoroutine(AttackCoolDown());
        }
    }

    IEnumerator AttackCoolDown()
    {
        yield return new WaitForSeconds(1);
        allowAttack = true;
    }
}
