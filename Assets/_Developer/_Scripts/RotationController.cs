using UnityEngine;

public class RotationController : MonoBehaviour
{
    //====================Handle the Planet Rotation====================//

    [Header("Rotate Planet")]
    [SerializeField] private Vector3 _rotationVector;
    [SerializeField] private float _rotationSpeed;
    
    //=====Update Method=====//
    private void Update()
    {
        transform.Rotate(_rotationVector * Time.deltaTime * _rotationSpeed);
    }

}
