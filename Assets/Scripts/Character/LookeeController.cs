using UnityEngine;

public class LookeeController : MonoBehaviour
{
    [Header("漂浮设置")] public float floatAmplitude = 0.2f; // 浮动高度

    public float floatFrequency = 1f; // 浮动速度

    [Header("动画")] public Animator animator; // 动画控制器

    [Header("音效")] public AudioSource audioSource; // 音效播放器

    public AudioClip greetClip; // 打招呼音效

    private Vector3 startPos;

    private void Start()
    {
        startPos = transform.position;
    }

    private void Update()
    {
        // 上下浮动
        var yOffset = floatAmplitude * Mathf.Sin(Time.time * floatFrequency);
        transform.position = new Vector3(startPos.x, startPos.y + yOffset, startPos.z);
    }

    private void OnMouseDown()
    {
        PlayGreet();
    }

    public void PlayGreet()
    {
        if (animator != null) animator.SetTrigger("Greet");

        if (audioSource != null && greetClip != null) audioSource.PlayOneShot(greetClip);
    }
}