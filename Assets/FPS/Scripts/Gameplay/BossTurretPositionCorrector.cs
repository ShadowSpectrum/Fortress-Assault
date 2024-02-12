using System.Collections;
using System.Collections.Generic;
//using Unity.Plastic.Antlr3.Runtime.Tree;
using UnityEngine;

public class BossTurretPositionCorrector : MonoBehaviour
{
    private float Y = 2.81F;
    [SerializeField] private float X = 31.07F;
    [SerializeField] private float Z = 27.59F;
    Vector3 PosT;
    Transform ObjectY; 
    // Start is called before the first frame update
    void Start()
    {
        PosT.x = X;
        PosT.y = Y;
        PosT.z = Z;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = PosT;
    }
}
