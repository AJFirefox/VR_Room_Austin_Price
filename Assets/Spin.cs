using JetBrains.Annotations;
using UnityEngine;

public class Spin : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
        public float rotationSpeed = 100f;
    

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);

    }
}
