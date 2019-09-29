using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class ObjectScript : MonoBehaviour
{
    public float speed;
    public int time;
    public GameObject box;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void BuildObject()
    {
        box = GameObject.CreatePrimitive(PrimitiveType.Cube);
        box.name = "Cube (Clone)";
    }
}
