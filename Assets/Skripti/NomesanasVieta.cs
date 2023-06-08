using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class NomesanasVieta : MonoBehaviour, 
	IDropHandler{
	private float vietasZRot, velkObjZRot, rotacijasStarpiba;
	private Vector2 vietasIzm, velkObjIzm;
	private float xIzmStarpiba, yIzmStarpiba;
	public Objekti objektuSkripts;
    //Definets mainigais lai parbaudit kad visas 12 mašinas ir savā vieta
    //Šo mainigo inkrementē katru reizi, kad mašina pielimējas pie savas vietas
    private static int masinasPareizaVieta = 0;

    public void OnDrop(PointerEventData eventData)
    {
		if (eventData.pointerDrag != null)
		{
			if (eventData.pointerDrag.tag.Equals(tag))
			{
				vietasZRot =
				eventData.pointerDrag.
				GetComponent<RectTransform>().transform.eulerAngles.z;

				velkObjZRot =
				GetComponent<RectTransform>().transform.eulerAngles.z;

				rotacijasStarpiba =
				Mathf.Abs(vietasZRot - velkObjZRot);

				vietasIzm =
				eventData.pointerDrag.
				GetComponent<RectTransform>().localScale;

				velkObjIzm =
					GetComponent<RectTransform>().localScale;

				xIzmStarpiba = Mathf.Abs(vietasIzm.x - velkObjIzm.x);
				yIzmStarpiba = Mathf.Abs(vietasIzm.y - velkObjIzm.y);

				Debug.Log("Objektu rotācijas starpība: " + rotacijasStarpiba
					+ "\nPlatuma starpība: " + xIzmStarpiba +
					"\nAugstuma starpība: " + yIzmStarpiba);


				if ((rotacijasStarpiba <= 6 ||
					(rotacijasStarpiba >= 354 && rotacijasStarpiba <= 360))
					&& (xIzmStarpiba <= 0.1 && yIzmStarpiba <= 0.1))
				{
					Debug.Log("Nomests pareizajā vietā!");
                    objektuSkripts.vaiIstajaVieta = true;
                    eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition
						= GetComponent<RectTransform>().anchoredPosition;

					eventData.pointerDrag.GetComponent<RectTransform>().localRotation =
						GetComponent<RectTransform>().localRotation;

					eventData.pointerDrag.GetComponent<RectTransform>().localScale =
						GetComponent<RectTransform>().localScale;

					switch (eventData.pointerDrag.tag) {
						case "atkritumi":
							objektuSkripts.skanasAvots.PlayOneShot(
								objektuSkripts.skanasKoAtskanot[1]);
                            masinasPareizaVieta++;
                            Debug.Log("Mašinas pareiza vieta: " + masinasPareizaVieta);
                            break;

						case "atrie":
							objektuSkripts.skanasAvots.PlayOneShot(
								objektuSkripts.skanasKoAtskanot[2]);
                            masinasPareizaVieta++;
                            Debug.Log("Mašinas pareiza vieta: " + masinasPareizaVieta);
                            break;

						case "buss":
							objektuSkripts.skanasAvots.PlayOneShot(
								objektuSkripts.skanasKoAtskanot[3]);
                            masinasPareizaVieta++;
                            Debug.Log("Mašinas pareiza vieta: " + masinasPareizaVieta);
                            break;

						case "b2":
							objektuSkripts.skanasAvots.PlayOneShot(objektuSkripts.skanasKoAtskanot[4]);
                            masinasPareizaVieta++;
                            Debug.Log("Mašinas pareiza vieta: " + masinasPareizaVieta);
                            break;

                        case "cements":
                            objektuSkripts.skanasAvots.PlayOneShot(objektuSkripts.skanasKoAtskanot[5]);
                            masinasPareizaVieta++;
                            Debug.Log("Mašinas pareiza vieta: " + masinasPareizaVieta);
                            break;

                        case "e46":
                            objektuSkripts.skanasAvots.PlayOneShot(objektuSkripts.skanasKoAtskanot[6]);
                            masinasPareizaVieta++;
                            Debug.Log("Mašinas pareiza vieta: " + masinasPareizaVieta);
                            break;

                        case "e61":
                            objektuSkripts.skanasAvots.PlayOneShot(objektuSkripts.skanasKoAtskanot[7]);
                            masinasPareizaVieta++;
                            Debug.Log("Mašinas pareiza vieta: " + masinasPareizaVieta);
                            break;

                        case "ekskavators":
                            objektuSkripts.skanasAvots.PlayOneShot(objektuSkripts.skanasKoAtskanot[8]);
                            masinasPareizaVieta++;
                            Debug.Log("Mašinas pareiza vieta: " + masinasPareizaVieta);
                            break;

                        case "policija":
                            objektuSkripts.skanasAvots.PlayOneShot(objektuSkripts.skanasKoAtskanot[9]);
                            masinasPareizaVieta++;
                            Debug.Log("Mašinas pareiza vieta: " + masinasPareizaVieta);
                            break;

                        case "traktors":
                            objektuSkripts.skanasAvots.PlayOneShot(objektuSkripts.skanasKoAtskanot[10]);
                            masinasPareizaVieta++;
                            Debug.Log("Mašinas pareiza vieta: " + masinasPareizaVieta);
                            break;

                        case "traktors2":
                            objektuSkripts.skanasAvots.PlayOneShot(objektuSkripts.skanasKoAtskanot[11]);
                            masinasPareizaVieta++;
                            Debug.Log("Mašinas pareiza vieta: " + masinasPareizaVieta);
                            break;

                        case "ugunsdzeseji":
                            objektuSkripts.skanasAvots.PlayOneShot(objektuSkripts.skanasKoAtskanot[12]);
                            masinasPareizaVieta++;
                            Debug.Log("Mašinas pareiza vieta: "+masinasPareizaVieta);
                            break;

                        default:
							Debug.Log("Tags nav definēts!");
							break;
					}
                    //Parbauda vai ir sasniegta uzvara
                    if (masinasPareizaVieta == 12)
                    {
                        Debug.Log("Uzvara!");
                    }
                }

				//Ja tagi nesakrīt, tātad nepareizajā vietā
			} else	{
				objektuSkripts.vaiIstajaVieta = false;
				objektuSkripts.skanasAvots.PlayOneShot(
					objektuSkripts.skanasKoAtskanot[0]);

                switch (eventData.pointerDrag.tag){
                    case "atkritumi":
						objektuSkripts.atkritumuMasina.
						GetComponent<RectTransform>().localPosition =
						objektuSkripts.atkrMKoord;
                        break;

                    case "atrie":
                        objektuSkripts.atraPalidziba.
                        GetComponent<RectTransform>().localPosition =
                        objektuSkripts.atrPKoord;
                        break;
                        
                    case "buss":
                        objektuSkripts.autobuss.
                         GetComponent<RectTransform>().localPosition =
                         objektuSkripts.bussKoord;
                        break;

					case "b2":
						objektuSkripts.b2.GetComponent<RectTransform>().localPosition = objektuSkripts.b2Koord;
						break;

                    case "cements":
                        objektuSkripts.cements.GetComponent<RectTransform>().localPosition = objektuSkripts.cementsKoord;
                        break;

                    case "e46":
                        objektuSkripts.e46.GetComponent<RectTransform>().localPosition = objektuSkripts.e46Koord;
                        break;

                    case "e61":
                        objektuSkripts.e61.GetComponent<RectTransform>().localPosition = objektuSkripts.e61Koord;
                        break;

                    case "ekskavators":
                        objektuSkripts.ekskavators.GetComponent<RectTransform>().localPosition = objektuSkripts.ekskavatorsKoord;
                        break;

                    case "policija":
                        objektuSkripts.policija.GetComponent<RectTransform>().localPosition = objektuSkripts.policijasKoord;
                        break;

                    case "traktors":
                        objektuSkripts.traktors.GetComponent<RectTransform>().localPosition = objektuSkripts.traktorsKoord;
                        break;

                    case "traktors2":
                        objektuSkripts.traktors2.GetComponent<RectTransform>().localPosition = objektuSkripts.traktorsKoord2;
                        break;

                    case "ugunsdzeseji":
                        objektuSkripts.ugunsdzeseji.GetComponent<RectTransform>().localPosition = objektuSkripts.ugunsdzesejiKoord;
                        break;

                    default:
                        Debug.Log("Tags nav definēts!");
                        break;
                }
            }
		}
		
	}

}
