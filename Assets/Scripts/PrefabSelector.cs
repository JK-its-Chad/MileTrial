﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabSelector : MonoBehaviour {

    public GameObject[] List;

    public GameObject givePrefab()
    {
        int i = Random.Range(0, List.Length);
        return List[i];
    }
}
