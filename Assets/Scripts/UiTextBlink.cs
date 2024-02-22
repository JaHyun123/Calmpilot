using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UiTextBlink : MonoBehaviour
{
    public Text text;
    public float blinkDuration = 3f;
    public float blinkInterval = 1f;
    public float fadeDuration = 1f; // ���̵� ���� �ð�

    void Start()
    {
        text.text = "<color=#FF0000>��ȭ</color> ������";
        StartCoroutine(Blink());
    }

    IEnumerator Blink()
    {
        while (true)
        {
            // ���̵� �ƿ�
            for (float t = 1.0f; t >= 0.0f; t -= Time.deltaTime / fadeDuration)
            {
                text.color = new Color(text.color.r, text.color.g, text.color.b, t);
                yield return null;
            }

            // �ؽ�Ʈ ��Ȱ��ȭ
            text.enabled = false;

            // ���� ����
            yield return new WaitForSeconds(blinkInterval);

            // �ؽ�Ʈ Ȱ��ȭ
            text.enabled = true;

            // ���̵� ��
            for (float t = 0.0f; t <= 1.0f; t += Time.deltaTime / fadeDuration)
            {
                text.color = new Color(text.color.r, text.color.g, text.color.b, t);
                yield return null;
            }
        }
    }
}
