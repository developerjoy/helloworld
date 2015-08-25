#define D

using System.Diagnostics;
using UnityEngine;


public class TestScript2 : MonoBehaviour
{
	// Use this for initialization
	void Start ()
    {
        debug();
	}

    [Conditional("DEBUG")]
    private void debug()
    {
        UnityEngine.Debug.Log("I'm debug information...");
    }

	// Update is called once per frame
	void Update () {
	  // test for git push.
	}
}
