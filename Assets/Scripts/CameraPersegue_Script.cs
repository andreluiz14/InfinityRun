using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPersegue_Script : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] float smoofhTime;
    [SerializeField] Vector3 offSet;

    private Vector3 velocidade = Vector3.zero;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void LateUpdate()
    {
        transform.position = Vector3.SmoothDamp(transform.position, target.position + offSet, ref velocidade, smoofhTime * Time.deltaTime);
    }
}
