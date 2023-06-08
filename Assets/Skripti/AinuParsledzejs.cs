using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AinuParsledzejs : MonoBehaviour {

	public void Sakt()
	{
		SceneManager.LoadScene("PilsetasKarte");
        NomesanasVieta nomesanasVieta = FindObjectOfType<NomesanasVieta>();

        if (nomesanasVieta != null)
        {

            NomesanasVieta.SetMasinasPareizaVieta(0);
        }
        else
        {
            Debug.LogError("UzvarasAttelosana component not found!");
        }
    }

	public void Atpakaļ()
	{
		SceneManager.LoadScene("Sakums");
	}

	public void Apturet()
	{
		Application.Quit();
	}

}
