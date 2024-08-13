using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Source.CodeBase
{
    public class SceneSwitcher
    {
        private readonly ICoroutineRunner _runner;
        private int _nextSceneIndex;

        public SceneSwitcher(ICoroutineRunner runner)
        {
            _nextSceneIndex = (int)SceneNames.Game;
            _runner = runner;
        }

        public void LoadScene(Action loadComplete = null) =>
            _runner.StartCoroutine(LoadSceneAsync(loadComplete));

        public void SetNextScene(SceneNames name) =>
            _nextSceneIndex = (int)name;

        private IEnumerator LoadSceneAsync(Action loadComplete)
        {
            AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(_nextSceneIndex);

            while (asyncLoad.isDone == false)
                yield return null;

            loadComplete?.Invoke();
        }
    }
}