using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Flashbang : MonoBehaviour
{
    [SerializeField]
    GameObject flashbangObject;

    private EventManager eventManager;
    private SpriteRenderer sr;

    void Start()
    {
        eventManager=gameObject.GetComponent<EventManager>();
        sr = flashbangObject.GetComponent<SpriteRenderer>();
    }

    IEnumerator FlashRoutine()
    {
        while(true) {
            // Sofort komplett weiß
            sr.color = new Color(1, 1, 1, 1);

            // 2 Sekunden warten
            yield return new WaitForSeconds(1f);

            // Langsam ausblenden
            float t = 1f;

            while (t > 0)
            {
                t -= 0.05f;
                sr.color = new Color(1, 1, 1, t);
                yield return new WaitForSeconds(0.02f);
            }

            sr.color = new Color(1, 1, 1, 0);

            yield return new WaitForSeconds(9f);
        }
    }

    void Update()
    {
        if (eventManager.rInt == 5)
        {
            StartCoroutine(FlashRoutine());
            eventManager.rInt = 0;
        }
    }
}
