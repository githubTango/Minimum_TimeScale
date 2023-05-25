using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraResolution : MonoBehaviour
{
    // 카메라로 스마트폰 게임 화면비 고정

    // 고정할 화면비 지정
    [SerializeField]
    private float fix_width = 9;
    [SerializeField]
    private float fix_height = 16;

    private void Awake()
    {
        Camera camera = GetComponent<Camera>();
        Rect rect = camera.rect;
        float scale_height = ((float)Screen.width / Screen.height) / ((float)fix_width / fix_height); // (가로 / 세로) 비율 고정
        float scale_width = 1f / scale_height;

        // 스마트폰 화면에 맞춰 카메라 rect값 변환
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
