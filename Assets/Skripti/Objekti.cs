﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objekti : MonoBehaviour {
	public GameObject atkritumuMasina;
	public GameObject atraPalidziba;
	public GameObject autobuss;
	public GameObject b2;
	public GameObject cements;
	public GameObject e46;
	public GameObject e61;
	public GameObject ekskavators;
	public GameObject policija;	
	public GameObject traktors;
	public GameObject traktors2;
	public GameObject ugunsdzeseji;
 
	[HideInInspector]
	public Vector2 atkrMKoord;
	[HideInInspector]
	public Vector2 atrPKoord;
	[HideInInspector]
	public Vector2 bussKoord;
	[HideInInspector]
	public Vector2 b2Koord;
	[HideInInspector]
	public Vector2 cementsKoord;
	[HideInInspector]
	public Vector2 e46Koord;
	[HideInInspector]
	public Vector2 e61Koord;
	[HideInInspector]
	public Vector2 ekskavatorsKoord;
	[HideInInspector]
	public Vector2 policijasKoord;
	[HideInInspector]
	public Vector2 traktorsKoord;
	[HideInInspector]
	public Vector2 traktorsKoord2;
	[HideInInspector]
	public Vector2 ugunsdzesejiKoord;

	public Canvas kanva;
	 
	public AudioSource skanasAvots;
	public AudioClip[] skanasKoAtskanot;

	[HideInInspector]
	public bool vaiIstajaVieta = false;

	public GameObject pedejaisVilktais = null;


	void Start() {
		atkrMKoord = atkritumuMasina.GetComponent<RectTransform>().localPosition;
        
		atrPKoord = atraPalidziba.GetComponent<RectTransform>().localPosition;

        bussKoord = autobuss.GetComponent<RectTransform>().localPosition;

		b2Koord = b2.GetComponent<RectTransform>().localPosition;

		cementsKoord = cements.GetComponent<RectTransform>().localPosition;

		e46Koord = e46.GetComponent<RectTransform>().localPosition;

		e61Koord = e61.GetComponent<RectTransform>().localPosition;

		ekskavatorsKoord = ekskavators.GetComponent<RectTransform>().localPosition;

		policijasKoord = policija.GetComponent<RectTransform>().localPosition;

		traktorsKoord = traktors.GetComponent<RectTransform>().localPosition;

        traktorsKoord2 = traktors2.GetComponent<RectTransform>().localPosition;

		ugunsdzesejiKoord = ugunsdzeseji.GetComponent<RectTransform>().localPosition;
    }
}
