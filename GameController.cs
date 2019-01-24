using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {


    public delegate void PlayerEvents();
    public static event PlayerEvents CambioLuz;
    public static event PlayerEvents AumentoPoder;
    public static event PlayerEvents ReduccionPoder;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.L))
        {
            CambioLuz();
        }
	}

    public static void AumentarPoder()
    {
        if (AumentoPoder != null)
        {
            AumentoPoder();
        }
    }

    public static void ReducirPoder()
    {
        if (ReduccionPoder != null)
        {
            ReduccionPoder();
        }
    }
}
    
