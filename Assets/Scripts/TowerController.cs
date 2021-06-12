using UnityEngine;

public class TowerController:MonoBehaviour
{
    public float RotateSpeed;

    private void Update()
    {
        if (Input.GetKey(KeyCode.A))
            transform.Rotate(0, -RotateSpeed, 0, Space.Self); 
        
        if (Input.GetKey(KeyCode.D))
            transform.Rotate(0, RotateSpeed, 0, Space.Self);

        if (Input.GetKey(KeyCode.W))
            transform.Rotate(0, 0, RotateSpeed, Space.Self);

        if (Input.GetKey(KeyCode.S))
            transform.Rotate(0, 0, -RotateSpeed, Space.Self);

        // Euler -> Quaternion 각도를 x, y, z로 보이게 해준다
        transform.localEulerAngles = new Vector3(
            0,
            transform.localEulerAngles.y,
            transform.localEulerAngles.z);
    }
}
