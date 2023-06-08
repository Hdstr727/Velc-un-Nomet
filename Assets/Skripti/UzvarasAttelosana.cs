using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UzvarasAttelosana : MonoBehaviour
{
    public GameObject uzvarasPanelis;
    public GameObject zvaignze1;
    public GameObject zvaignze2;
    public GameObject zvaignze3;
    private float startTime;
    public float logDelay = 2f;

    private void Start()
    {
        StartTimer();
    }

    private void StartTimer()
    {
        startTime = Time.time;
        StartCoroutine(LogElapsedTime());
    }

    private System.Collections.IEnumerator LogElapsedTime()
    {
        while (true)
        {
            float elapsedTime = Time.time - startTime;

            // Parāda laiku
            Debug.Log("Elapsed Time: " + elapsedTime.ToString("F2"));

            // Gaida
            yield return new WaitForSeconds(logDelay);
        }
    }
    public void AttelotUzvaru()
    {

    }


}
