using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraResolution : MonoBehaviour
{
    // ī�޶�� ����Ʈ�� ���� ȭ��� ����

    // ������ ȭ��� ����
    [SerializeField]
    private float fix_width = 9;
    [SerializeField]
    private float fix_height = 16;

    private void Awake()
    {
        Camera camera = GetComponent<Camera>();
        Rect rect = camera.rect;
        float scale_height = ((float)Screen.width / Screen.height) / ((float)fix_width / fix_height); // (���� / ����) ���� ����
        float scale_width = 1f / scale_height;

        // ����Ʈ�� ȭ�鿡 ���� ī�޶� rect�� ��ȯ
        if(scale_height < 1)
        {
            rect.height = scale_height;
            rect.y = (1f - scale_height) / 2f;
        }
        else
        {
            rect.width = scale_width;
            rect.x = (1f - scale_width) / 2f;
        }

        camera.rect = rect;
    }
}
