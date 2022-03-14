using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    #region Variables
    public GameObject target;
    public Vector3 offsett;
    public float smoothnessRate = 0.15f;
    #endregion / Variables
    #region Default Methods

    void FixedUpdate()
    {
        Vector3 targetPos = target.transform.position + offsett;
        transform.position = Vector3.Lerp(transform.position, targetPos, smoothnessRate);
    }
    #endregion / Default Methods
}