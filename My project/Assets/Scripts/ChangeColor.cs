using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public Perceptron perceptron;
    [SerializeField] private int experementNumber;

    private void OnCollisionEnter(Collision other)
    {
        var perceptronRes = perceptron.GetComponent<Perceptron>().testResults;

        for (var i = 0; i < perceptronRes.Count; i++)
        {
            if (i == experementNumber && perceptronRes[i] == 0)
            {
                other.gameObject.GetComponent<Renderer>().material.color = Color.white;
                this.gameObject.GetComponent<Renderer>().material.color = Color.white;
                break;
            }
            else if (i == experementNumber && perceptronRes[i] == 1)
            {
                other.gameObject.GetComponent<Renderer>().material.color = Color.black;
                this.gameObject.GetComponent<Renderer>().material.color = Color.black;
                break;
            }
        }
    }
}
