using UnityEngine;
using UnityEditor;

public class CompileLock : MonoBehaviour
{
    [MenuItem("Compile/Lock", false, 1)]
    static void Lock()
    {
        Debug.Log("コンパイルしなくなります");
        EditorApplication.LockReloadAssemblies();
    }

    [MenuItem("Compile/UnLock", false, 1)]
    static void Unlock()
    {
        Debug.Log("コンパイルするようになります");
        EditorApplication.UnlockReloadAssemblies();
    }
}