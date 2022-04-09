using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
    [SerializeField] [Range(1, 5)] private float ampX;
    [SerializeField] [Range(1, 5)] private float ampY;
    [SerializeField] [Range(1, 5)] private float factor;

    private void Start()
    {
        ampX = Random.Range(1, 5);
        ampY = Random.Range(1, 5);
        factor = Random.Range(1, 5);
    }

    void Update()
    {
        float x = ampX * Mathf.Sin(Time.time * factor);
        float y = ampY * Mathf.Sin(Time.time * factor);
        transform.position = new Vector3(x, y, 0);
    }
}
