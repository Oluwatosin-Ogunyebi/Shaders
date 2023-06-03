using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dissolve : MonoBehaviour
{
    [SerializeField] private Renderer meshRend;
    // Start is called before the first frame update
    void Start()
    {
        meshRend.material.SetFloat("_DissolveValue", 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            meshRend.material.SetFloat("_DissolveValue", 1);
        }

        if (Input.GetKeyDown(KeyCode.Z))
        {
            meshRend.material.SetFloat("_DissolveValue", 0);
        }
    }
}
