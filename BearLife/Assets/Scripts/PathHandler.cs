﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathHandler : MonoBehaviour
{
    [SerializeField]
    private List<Transform> path;
    private void Start()
    {
        for (int i = 0; i < transform.childCount; ++i)
        {
            path.Add(transform.GetChild(i));
        }
    }

    public Queue<Transform> GetPath(int currentPosition, int length)
    {
        Queue<Transform> r = new Queue<Transform>();
        for(int i = 0; i < length; ++i)
        {
            r.Enqueue(path[(currentPosition+1+i)%path.Count]);
        }

        return r;
    }
}