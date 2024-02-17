using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Mic : MonoBehaviour
{
    public AudioSource mic; //����ũ�� ������ �Ҹ��� ����� ������ҽ� ������Ʈ

    void Start()
    {
        //��ǻ�Ϳ� ��ϵ� ����ũ�� �迭�� ���
        string[] myMic = Microphone.devices;
        for (int i = 0; i < myMic.Length; i++)
        {
            Debug.Log(Microphone.devices[i].ToString());
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            //����� �ҽ� Ŭ���� ����ũ���� ����(�迭 �ȿ� ���ڸ� ���� ����ũ ����)
            //100�� 44100�� ���� ���� ��
            mic.clip = Microphone.Start(Microphone.devices[0].ToString(), true, 100, 44100);
            //�����̸� ���̱� ���� �߰��� �ڵ�
            while (!(Microphone.GetPosition(null) > 0)) { }
            //����ũ ���� ���
            mic.Play();
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            mic.Stop();
        }
    }
}