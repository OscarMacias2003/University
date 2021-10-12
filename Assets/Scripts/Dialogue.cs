using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialogue : MonoBehaviour
{
    public TextMeshProUGUI TextD;

    [TextArea(30, 30)]

    public string[] paragraphs;
    int index;
    public float SpeedParagraph;

    public GameObject BotonContinue;
    public GameObject BotonRemove;

    public GameObject DialoguePanel;
    public GameObject BotonRead;

    public GameObject Notess;

  
    void Start()
    {
        BotonRemove.SetActive(false);
        BotonRead.SetActive(false);
        DialoguePanel.SetActive(false);
    }


    void Update()
    {
        if (TextD.text == paragraphs[index])
        {
            BotonContinue.SetActive(true);
            
        }
    }



    IEnumerator TextDialogue()
    {
        BotonRead.SetActive(false);
        BotonContinue.SetActive(false);
        foreach (char letra in paragraphs[index].ToCharArray())
        {
            TextD.text += letra;

            yield return new WaitForSeconds(SpeedParagraph);

        }
    }


    public void NextParagraph()
    {
        BotonContinue.SetActive(false);
        if (index < paragraphs.Length - 1)
        {
            index++;
            TextD.text = "";
            StartCoroutine(TextDialogue());

        }
        else
        {
            TextD.text = "";
            BotonContinue.SetActive(false);
            BotonRemove.SetActive(true);

        }
    }


    public void activateBotonRead()
    {
        DialoguePanel.SetActive(true);
        BotonRead.SetActive(false);
        StartCoroutine(TextDialogue());
    }

    public void CerrarBoton()
    {
        DialoguePanel.SetActive(false);
        Notess.SetActive(false);
    }
    
}

