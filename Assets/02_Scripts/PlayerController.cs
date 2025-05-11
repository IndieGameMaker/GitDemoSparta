using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Transform transform;
    // Start is called before the first frame update
    void Start()
    {
        transform = this.transform;
        Debug.Log("aaa");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * 2.0f);
    }
}
