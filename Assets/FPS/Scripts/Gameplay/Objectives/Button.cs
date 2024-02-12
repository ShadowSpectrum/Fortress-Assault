using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
//using UnityEditor.UI;
using UnityEngine;
using UnityEngine.Events;

public class Button : MonoBehaviour
{
    [SerializeField] private float OpenSpeed;
    [SerializeField] private Color Pressed = Color.green;
    [SerializeField] private GameObject Door;

    private void Start()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            //Invocar o método enviando o Game Object
            var Rend = this.gameObject.GetComponent<Renderer>().materials;
            Rend[1].color = Pressed;

            Destroy(Door);
        }
    }
}
