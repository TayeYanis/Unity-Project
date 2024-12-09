using UnityEngine;
using TMPro;

public class ImprimanteBehaviour : MonoBehaviour
{
    public TMP_Text screenText;
    public bool isPrinting;

    public GameObject printButton;

    void Start()
    {
        printButton.SetActive(false);
    }

    public void ShowPrintButton() 
    {
        printButton.SetActive(true);
    }
}
