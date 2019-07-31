using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrashExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // works in all builds
        var obj1 = Resources.Load("myPrefab");
        Debug.Log(obj1); // prints "myPrefab (UnityEngine.GameObject)"

        // works in all builds
        GameObject obj2 = Resources.Load<GameObject>("myPrefab");
        Debug.Log(obj2); // prints "myPrefab (UnityEngine.GameObject)"

        // Works if built locally but fails if built by Unity Cloud for iOS
        SomeComponent exampleBehavior123 = Resources.Load<SomeComponent>("myPrefab");
        // Unity Editor and local iOS build prints "myPrefab (SomeComponent)"
        // Unity Cloud iOS build prints "null"
        Debug.Log(exampleBehavior123);
    }
}
