using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteSave : MonoBehaviour
{
    void Start()
    {
        PlayerPrefs.DeleteAll();
    }
}
