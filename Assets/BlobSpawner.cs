using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlobSpawner : MonoBehaviour
{
    public GameObject blobPrefab;
    public Transform spawnPoint;

    public int rInt;

    private bool started = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(rInt == 1 && !started)
        {
            started = true;
            StartCoroutine(SpawnBlob());
        }
    }

    IEnumerator SpawnBlob()
    {
        while (true)
        {
            Instantiate(blobPrefab, spawnPoint.position, Quaternion.identity);
            yield return new WaitForSeconds(5f);
        }
    }
}
