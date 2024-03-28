using UnityEngine;

public class Cube : MonoBehaviour
{
    [SerializeField] private float _speedMove;
    [SerializeField] private float _speedRotation;
    [SerializeField] private float _speedScale;

    private void Update()
    {
        MoveForward();
        RotationByY();
        Scale();
    }

    private void MoveForward()
    {
        transform.Translate(Vector3.forward * _speedMove * Time.deltaTime);
    }

    private void RotationByY()
    {
        transform.Rotate(0, _speedRotation * Time.deltaTime, 0);
    }

    private void Scale()
    {
        transform.localScale += new Vector3(_speedScale, _speedScale, _speedScale) * Time.deltaTime;
    }
}
