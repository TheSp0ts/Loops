﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReverseArray : MonoBehaviour {
    List<int> list1 = new List<int>();
    List<int> list2 = new List<int>();// Use this for initialization

    void Start()
    {   //Adds to list.
        list1.Add(1);
        list1.Add(7);
        list1.Add(69);
        list1.Add(420);
        list1.Add(666);
        list1.Add(999);
        //Makes a reverse loop that goes as long as its not at the beginning of the list
        for (int i = list1.Count - 1; i >= 0; i--)
        {
            list2.Add(list1[i]);
        }
        //Makes a loop that prints the list
        for (int i = 0; i < list2.Count; i++)
        {
            print(list2[i]);
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}