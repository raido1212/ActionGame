using UnityEngine;
using UnityEditor;

public class CompileLock : MonoBehaviour
{
    [MenuItem("Compile/Lock", false, 1)]
    static void Lock()
    {
        Debug.Log("�R���p�C�����Ȃ��Ȃ�܂�");
        EditorApplication.LockReloadAssemblies();
    }

    [MenuItem("Compile/UnLock", false, 1)]
    static void Unlock()
    {
        Debug.Log("�R���p�C������悤�ɂȂ�܂�");
        EditorApplication.UnlockReloadAssemblies();
    }
}