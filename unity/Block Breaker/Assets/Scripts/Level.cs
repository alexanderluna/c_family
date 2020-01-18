using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{

    [SerializeField] int blocks;


    public void AddBlock()
    {
        blocks++;
    }


    public void RemoveBlock()
    {
        blocks--;
    }
}
