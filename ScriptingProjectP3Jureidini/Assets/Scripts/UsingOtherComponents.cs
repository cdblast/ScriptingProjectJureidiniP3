using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsingOtherComponents : MonoBehaviour
{
    public GameObject otherGameObject;

    private AnotherScript anotherscript;
    private YetAnotherScript yetAnotherScript;
    private BoxCollider boxCol;
    // Start is called before the first frame update
    void Awake()
    {
        anotherscript = GetComponent<AnotherScript>();
        yetAnotherScript = otherGameObject.GetComponent<YetAnotherScript>();
        boxCol = otherGameObject.GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        boxCol.size = new Vector3(3, 3, 3);
        Debug.Log("The player's score is " + anotherscript.playerScore);
        Debug.Log("The player has died " + yetAnotherScript.numberOfPlayerDeaths + " times");
    }
}