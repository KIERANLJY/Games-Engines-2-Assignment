using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AstraFightSpawner : MonoBehaviour
{

    public GameObject astraFighter;
    private int sum;
    private bool allowSpawn;

    // Start is called before the first frame update
    void Start()
    {
        sum = 0;
        allowSpawn = true;
    }

    // Update is called once per frame
    void Update()
    {
        Attack();
    }

    void Attack()
    {
        Vector3 pos = new Vector3(transform.position.x, transform.position.y - 20, transform.position.z + 30);
        if (sum < 8 && allowSpawn)
        {
            GameObject.Instantiate(astraFighter, pos, this.transform.rotation);
            allowSpawn = false;
            sum += 1;
            StartCoroutine(AttackCoolDown());
        }
    }

    IEnumerator AttackCoolDown()
    {
        yield return new WaitForSeconds(3);
        allowSpawn = true;
    }
}
