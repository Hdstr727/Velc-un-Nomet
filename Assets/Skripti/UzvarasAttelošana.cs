using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UzvarasAttelošana : MonoBehaviour {
	public GameObject uzvarasPanelis;
	public GameObject zvaignze1;
	public GameObject zvaignze2;
	public GameObject zvaignze3;
    private float startTime;

    private void Start()
    {
        StartTimer();
    }
    private void StartTimer()
    {
        startTime = Time.time;
    }

    private void Update()
    {
        float elapsedTime = Time.time - startTime;

        // You can use the elapsed time for various purposes
        Debug.Log("Elapsed Time: " + elapsedTime.ToString("F2"));
    }
    public void UzvarasAttelosana()
	{
		
	}

	
}
