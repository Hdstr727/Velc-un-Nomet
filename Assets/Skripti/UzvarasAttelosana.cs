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
        // Aprēķina pagājušo laiku
        float elapsedTime = Time.time - startTime;

        // Iestata uzvarasPanelis objektu redzamu
        uzvarasPanelis.transform.localScale = Vector3.one;

        // Pārbauda pagājušo laiku un iestata redzamo zvaigžņu skaitu atbilstoši noteiktajiem nosacījumiem
        if (elapsedTime < 120f)
        {
            // Parāda 3 zvaigznes
            zvaignze1.transform.localScale = Vector3.one;
            zvaignze2.transform.localScale = Vector3.one;
            zvaignze3.transform.localScale = Vector3.one;
            Debug.Log("Elapsed Time: " + elapsedTime.ToString("F2") + "- 3 zvaigznes");

        }
        else if (elapsedTime >= 120f && elapsedTime < 240f)
        {
            // Parāda 2 zvaigznes
            zvaignze1.transform.localScale = Vector3.one;
            zvaignze2.transform.localScale = Vector3.one;
            zvaignze3.transform.localScale = Vector3.zero;
            Debug.Log("Elapsed Time: " + elapsedTime.ToString("F2") + " - 2 zvaigznes");
        }
        else if (elapsedTime >= 240f && elapsedTime < 360f)
        {
            // Parāda 1 zvaigzni
            zvaignze1.transform.localScale = Vector3.one;
            zvaignze2.transform.localScale = Vector3.zero;
            zvaignze3.transform.localScale = Vector3.zero;
            Debug.Log("Elapsed Time: " + elapsedTime.ToString("F2") + " - 1 zvaigzne");
        }
        else
        {
            // Nav zvaigžņu
            zvaignze1.transform.localScale = Vector3.zero;
            zvaignze2.transform.localScale = Vector3.zero;
            zvaignze3.transform.localScale = Vector3.zero;
            Debug.Log("Elapsed Time: " + elapsedTime.ToString("F2") + "- 0 zvaigznes");
        }
    }


}
