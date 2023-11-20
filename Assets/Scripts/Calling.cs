using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Calling : MonoBehaviour

{
    public GameObject uiElement;
    public GameObject Call; 
    public AudioSource audioSource;
    public AudioSource voice;


    // ��ư Ŭ�� �� ȣ��� �Լ�
    public void OnButtonClick()
    {
        audioSource.Play(); // ���� ���
        Call.SetActive(true);
        uiElement.SetActive(false);
        Invoke("PlaySound", 2f);
        Invoke("Mainmenu", 23f);

    }

public void Mainmenu()
    {
        Call.SetActive(false);
    }
public void PlaySound()
{
    voice.Play();
}
}