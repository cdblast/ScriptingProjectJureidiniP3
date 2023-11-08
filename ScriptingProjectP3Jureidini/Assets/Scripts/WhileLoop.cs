using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhileLoop : MonoBehaviour
{
    int cupsinsink = 4;
    // Start is called before the first frame update
    void Start()
    {
        while(cupsinsink > 0)
        {
            Debug.Log("I've washed a cup!");
            cupsinsink--;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
