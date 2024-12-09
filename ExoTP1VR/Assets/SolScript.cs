using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SolScript : MonoBehaviour
{
    public TMP_Text PointsText;
    int compteur;

    // Start is called before the first frame update
    void Start()
    {
        PointsText.text = "0";
        compteur = 0;
        
    }

    void OnTriggerEnter(Collider other) {
        if (other.tag == "Cylinder")
        {
        compteur++;
        Debug.Log(compteur);
        PointsText.text = compteur.ToString();
        }

    }

}
