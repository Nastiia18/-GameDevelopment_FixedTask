using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening; 

public class RotateCube : MonoBehaviour
{
    [SerializeField] private float rotationAngle = 360f; 
    [SerializeField] private float rotationDuration = 2f;
    [SerializeField] private Ease rotationEase = Ease.InOutQuad; 
    [SerializeField] private KeyCode rotationKey = KeyCode.Alpha1; 

    void Update()
    {
      
        if (Input.GetKeyDown(rotationKey))
        {
            Debug.Log($"<color=yellow>Pressed button '{rotationKey}'</color> : <color=green>Rotating the object</color>");
   
            Rotate();
        }
    }

    private void Rotate()
    {
        transform.DORotate(new Vector3(0, rotationAngle, 0), rotationDuration, RotateMode.LocalAxisAdd)
            .SetEase(rotationEase); 
    }
}