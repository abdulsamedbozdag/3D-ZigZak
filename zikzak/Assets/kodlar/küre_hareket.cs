using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class küre_hareket : MonoBehaviour
{
    Vector3 yön;
    public float hiz;

    // Start is called before the first frame update
    void Start()
    {
        yön = Vector3.forward;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            if(yön.x==0)
            {
                yön = Vector3.left;
            }
            else
            {
                yön = Vector3.forward;
            }
        }
        
    }
    private void FixedUpdate()
    {
        Vector3 kure_move = yön * Time.deltaTime * hiz;
        transform.position += kure_move;
    }
}
