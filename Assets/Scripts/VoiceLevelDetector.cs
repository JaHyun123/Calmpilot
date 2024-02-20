/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoiceLevelDetector : MonoBehaviour
{
    private Microphone _microphone;
    private float[] _spectrumData;

    private void Start()
    {
        // ����ũ�� �ʱ�ȭ�մϴ�.
        _microphone = Microphone.Start(null, 44100, 1);
        _spectrumData = new float[256];
    }

    private void Update()
    {
        // ���� ����Ʈ�� �����͸� �����ɴϴ�.
        _microphone.GetSpectrumData(_spectrumData, 0, FFTWindow.BlackmanHarris);

        // ��Ҹ� ũ�⸦ ����մϴ�.
        float voiceLevel = 0f;
        for (int i = 0; i < _spectrumData.Length; i++)
        {
            voiceLevel += _spectrumData[i];
        }

        // ��Ҹ� ũ�Ⱑ ������ UI�� "��Ҹ��� Ű�켼��" �޽����� ���ϴ�.
        if (voiceLevel < 0.5f)
        {
            // UI�� Ȱ��ȭ�մϴ�.
            ui.SetActive(true);
        }
        else
        {
            // UI�� ��Ȱ��ȭ�մϴ�.
            ui.SetActive(false);
        }
    }
}*/