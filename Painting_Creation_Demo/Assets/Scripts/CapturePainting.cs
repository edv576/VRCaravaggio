using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapturePainting : MonoBehaviour {

    public RenderTexture paintingScreen;

	// Use this for initialization
	void Start () {
		


	}

    IEnumerator FreezeCam()
    {
        //yield return null;
        Camera.main.clearFlags = CameraClearFlags.Nothing;
        yield return null;
        Camera.main.cullingMask = 0;
    }

    void StartFreezing()
    {
        StartCoroutine("FreezeCam");

    }

    // Update is called once per frame
    void Update () {

        if(Input.GetKeyDown(KeyCode.Space))
        {
            StartFreezing();

        }

		
	}
}
