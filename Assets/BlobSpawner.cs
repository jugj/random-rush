using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlobSpawner : MonoBehaviour
{
    public GameObject blobPrefab;
    public Transform spawnPoint;
    [SerializeField]
    GameObject Blob_active;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Blob_active == null)
        {
            SpawnBlob();
        }
    }

    void SpawnBlob()
    {

            Blob_active=Instantiate(blobPrefab, spawnPoint.position, Quaternion.identity);

    }
}
