using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    public float minSpeed = 4.0f;
    public float maxSpeed = 12.0f;
    public float health = 100.0f;
    public float damage = 10.0f;
    public float lifeTime = 30.0f;
    public int rarity = 1;
    // Start is called before the first frame update
    void Start()
    {
        //Execute the coroutine
        StartCoroutine(DestroyEnemy());
    }

    // Update is called once per frame
    void Update()
    {
        //Move the enemy on -X axis
        transform.Translate(Vector3.left * Random.Range(minSpeed, maxSpeed) * Time.deltaTime);
    }

    //Make coroutine to destroy enemy after 10 seconds
    IEnumerator DestroyEnemy()
    {
        yield return new WaitForSeconds(lifeTime);
        Destroy(gameObject);
    }
}
