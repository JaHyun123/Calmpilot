using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class earthquake : MonoBehaviour
{
    public float shakeDuration = 2f; // ������ ���ӵǴ� �ð�
    public float shakeMagnitude = 0.1f; // ������ ����
    public float waitTime = 0.05f; // ���� ���� ��� �ð�

    private Vector3 originalPosition;
    private bool isShaking = false;

    private void Start()
    {
        originalPosition = transform.position;
    }

    private void Update()
    {
        // ������ ���۵Ǹ�
        if (Input.GetKeyDown(KeyCode.Space)) // Space Ű�� ���� ������ �����մϴ�. ���ϴ� �ٸ� Ű�� ���� �����մϴ�.
        {
            StartCoroutine(StartShake());
        }

        // ������ ������ ���� ��ġ�� ���ư��� �մϴ�.
        if (!isShaking)
        {
            transform.position = originalPosition;
        }
    }

    private IEnumerator StartShake()
    {
        isShaking = true;

        float elapsed = 0f;

        while (elapsed < shakeDuration)
        {
            float x = Random.Range(-1f, 1f) * shakeMagnitude;
            float y = Random.Range(-1f, 1f) * shakeMagnitude;
            float z = Random.Range(-1f, 1f) * shakeMagnitude;

            transform.position = new Vector3(originalPosition.x + x, originalPosition.y + y, originalPosition.z + z);

            elapsed += Time.deltaTime;

            yield return new WaitForSeconds(waitTime); // ���� ���� ��� �ð��� �߰��մϴ�.
        }

        isShaking = false;
    }
}