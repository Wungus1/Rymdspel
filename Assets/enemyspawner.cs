using System.Collections;
using UnityEngine;

public class enemyspawner : MonoBehaviour
{
    public GameObject Fatguy;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(Spawner());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public IEnumerator Spawner()
    {
        while (true)
        {

        
        var position = new Vector2(Random.Range(-6.0f, 6.0f), 10);
        Instantiate(Fatguy, position, transform.rotation);
        
        yield return new WaitForSeconds(3);
        }
    }
}
