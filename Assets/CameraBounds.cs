using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBounds : MonoBehaviour
{
    [SerializeField] private Camera cam;
    private float halfWidth;
    private float halfHeight;

    // Start is called before the first frame update
    void Start()
    {

        SpriteRenderer sr = GetComponent<SpriteRenderer>();
        halfWidth = sr.bounds.extents.x;
        halfHeight = sr.bounds.extents.y;
    }

    // Update is called once per frame
    void LateUpdate()
    {
       Vector3 pos = transform.position;

       float minX = cam.transform.position.x - cam.orthographicSize * cam.aspect + halfWidth;
       float maxX = cam.transform.position.x + cam.orthographicSize * cam.aspect - halfWidth;

       float minY = cam.transform.position.y - cam.orthographicSize + halfHeight;
       float maxY = cam.transform.position.y + cam.orthographicSize - halfHeight;
       
       pos.x = Mathf.Clamp(pos.x, minX, maxX);
       pos.y = Mathf.Clamp(pos.y, minY, maxY);

       transform.position = pos;
    }
}
