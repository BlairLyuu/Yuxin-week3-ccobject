using UnityEngine;
using UnityEngine.UI;

public class StartGameUI : MonoBehaviour
{
    public Rigidbody ball;         // 小球刚体
    public GameObject startText;   // “Click anywhere to start” 文本
    public Button fullScreenButton;// 全屏透明按钮

    void Start()
    {
        // 开始时冻结球
        if (ball) ball.isKinematic = true;

        // 注册按钮事件
        if (fullScreenButton)
            fullScreenButton.onClick.AddListener(OnStartClicked);
    }

    void OnStartClicked()
    {
        // 1. 解冻球
        if (ball) ball.isKinematic = false;

        // 2. 隐藏提示文字
        if (startText) startText.SetActive(false);

        // 3. 隐藏按钮自己（否则会一直挡在屏幕上）
        if (fullScreenButton) fullScreenButton.gameObject.SetActive(false);
    }
}
