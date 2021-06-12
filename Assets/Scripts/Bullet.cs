using System.Collections;
using UnityEngine;



public class Bullet : MonoBehaviour
{
    private void Update()
    {
        if (transform.localPosition.y <= -20.0f)
            Destroy(gameObject);
    }
}
 