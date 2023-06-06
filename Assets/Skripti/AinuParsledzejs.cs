using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AinuParsledzejs : MonoBehaviour {

	public void Sakt()
	{
		SceneManager.LoadScene("PilsetasKarte");
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
