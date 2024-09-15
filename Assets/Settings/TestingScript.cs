using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AA0000
{
    public class TestingScript : MonoBehaviour
    {
        private Vector3 axis = Vector3.up;
        public float rotationSpeed = 1.0f;

        void Update()
        {
            transform.Rotate(axis, rotationSpeed * Time.deltaTime);
        }
    } 
}
