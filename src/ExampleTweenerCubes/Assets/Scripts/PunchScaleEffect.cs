using DG.Tweening;
using UnityEngine;

public class PunchScaleEffect : MonoBehaviour
{
    [SerializeField] private Vector3 punchScale = new Vector3(1.5f, 1.5f, 1.5f); 
    [SerializeField] private float punchDuration = 1f; 
    [SerializeField] private KeyCode punchKey = KeyCode.Alpha2; 

    void Update()
    {
        if (Input.GetKeyDown(punchKey))
        {
            Debug.Log($"<color=yellow>Pressed button '{punchKey}'</color> : <color=red>Punching scale</color>");
            PunchScale();
        }
    }

    private void PunchScale()
    {
        transform.DOPunchScale(punchScale, punchDuration, 1, 0.25f);  
    }
}