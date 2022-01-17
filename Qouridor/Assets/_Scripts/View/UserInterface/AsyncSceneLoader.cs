using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public sealed class AsyncSceneLoader {
    private AsyncOperation _asyncLoad;
        
    public IEnumerator LoadSceneRoutine(int sceneID) {
        _asyncLoad = SceneManager.LoadSceneAsync(sceneID);
        SetLoadPermission(false);

        while (!_asyncLoad.isDone) {
            yield return null;
        }
    }
    public void SetLoadPermission(bool isAllowed) {
        _asyncLoad.allowSceneActivation = isAllowed;
    }
}
