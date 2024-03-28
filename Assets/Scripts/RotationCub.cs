using UnityEngine;

public class RotationCub : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        RotationByY();
    }

    private void RotationByY()
    {
        transform.Rotate(0, _speed * Time.deltaTime, 0);
    }
}
