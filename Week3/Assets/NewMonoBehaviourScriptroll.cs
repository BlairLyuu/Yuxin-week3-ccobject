using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class NudgeOnHit : MonoBehaviour
{
    public Vector3 axis = new Vector3(0, 1, 0); // 和 HingeJoint 的 Axis 保持一致
    public float torqueImpulse = 60f;           // 冲量大小，转不动就再加大

    void OnCollisionEnter(Collision c)
    {
        if (c.rigidbody == null) return; // 只对有刚体的碰撞物触发
        GetComponent<Rigidbody>().AddTorque(axis.normalized * torqueImpulse, ForceMode.Impulse);
    }
}
