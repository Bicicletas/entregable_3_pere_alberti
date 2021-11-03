using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.localScale += 2*Vector3.one;
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            transform.rotation *= Quaternion.Euler(45, 0, 45);
        }
    }
}
