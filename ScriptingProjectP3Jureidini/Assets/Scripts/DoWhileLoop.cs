using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoWhileLoop : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        bool shouldContiue = false;

        do
        {
            print("Hello World");
        }while( shouldContiue == true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
