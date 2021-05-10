using UnityEngine;

public class GyroRotation : MonoBehaviour
{
    [Header("Tweaks")]
    [SerializeField] private Quaternion baseRotation = new Quaternion(1, 1, 0, 0);

    // Start is called before the first frame update
    void Start()
    {
        gyroManager.Instance.EnableGyro();
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.localRotation = gyroManager.Instance.GetGyroRotation() * baseRotation;
    }
}
