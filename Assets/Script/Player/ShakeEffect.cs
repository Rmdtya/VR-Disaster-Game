using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakeEffect : MonoBehaviour
{
    [SerializeField] private float _duration;
    [SerializeField] private float _magnitude;


    void Start()
    {
        // Memanggil fungsiFoo setiap 5 detik
        InvokeRepeating("StartShake", 0f, 5f);
    }

    IEnumerator StartShake()
    {
        StartCoroutine(Shake(_duration, _magnitude));
        yield return null;
    }

    private IEnumerator Shake(float duration, float magnitude)
    {
        Vector3 originalPos = transform.localPosition;

        float elapsed = 0.0f;
        while(elapsed < duration)
        {
            float x = Random.Range(-1f, 1f) * magnitude;
            float y = Random.Range(-1f, 1f) * magnitude;

            transform.localPosition = new Vector3(x, y, originalPos.z);
            elapsed += Time.deltaTime;

            yield return null;

        }
        transform.localPosition = originalPos;
    } 
}
