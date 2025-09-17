using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class NudgeOnHit : MonoBehaviour
{
    public Vector3 axis = new Vector3(0, 1, 0); // �� HingeJoint �� Axis ����һ��
    public float torqueImpulse = 60f;           // ������С��ת�������ټӴ�

    void OnCollisionEnter(Collision c)
    {
        if (c.rigidbody == null) return; // ֻ���и������ײ�ﴥ��
        GetComponent<Rigidbody>().AddTorque(axis.normalized * torqueImpulse, ForceMode.Impulse);
    }
}
