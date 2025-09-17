using UnityEngine;
using UnityEngine.UI;

public class StartGameUI : MonoBehaviour
{
    public Rigidbody ball;         // С�����
    public GameObject startText;   // ��Click anywhere to start�� �ı�
    public Button fullScreenButton;// ȫ��͸����ť

    void Start()
    {
        // ��ʼʱ������
        if (ball) ball.isKinematic = true;

        // ע�ᰴť�¼�
        if (fullScreenButton)
            fullScreenButton.onClick.AddListener(OnStartClicked);
    }

    void OnStartClicked()
    {
        // 1. �ⶳ��
        if (ball) ball.isKinematic = false;

        // 2. ������ʾ����
        if (startText) startText.SetActive(false);

        // 3. ���ذ�ť�Լ��������һֱ������Ļ�ϣ�
        if (fullScreenButton) fullScreenButton.gameObject.SetActive(false);
    }
}
