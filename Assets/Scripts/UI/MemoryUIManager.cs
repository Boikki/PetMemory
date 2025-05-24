using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MemoryUIManager : MonoBehaviour
{
    public GameObject panel;
    public Text memoryText;
    public Image memoryImage;

    public static MemoryUIManager Instance;

    private void Awake()
    {
        Instance = this;
        panel.SetActive(false);
    }

    public void Show(string text, Sprite image)
    {
        memoryText.text = text;
        memoryImage.sprite = image;
        panel.SetActive(true);
    }

    public void Hide()
    {
        panel.SetActive(false);
    }
}
