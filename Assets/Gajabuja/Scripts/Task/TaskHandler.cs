using System;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Gajabuja.Scripts.Task
{
    public class TaskHandler: MonoBehaviour, ITask
    {
        [SerializeField] private TextMeshProUGUI _textMeshPro;
        [SerializeField] private int _noOfTask;

        private int _taskCompleted = 0;

        private void Start()
        {
            UpdateHUD();
        }

        public void UpdateTaskCount()
        {
            _taskCompleted++;
            UpdateHUD();
            Check();
        }

        private void UpdateHUD()
        {
            _textMeshPro.text = $"{_taskCompleted}/{_noOfTask} tasks completed";
        }
        
        public void Check()
        {
            if (_taskCompleted >= _noOfTask)
            {
                StartCoroutine(ExecuteWinCondition());
            }
        }

        private IEnumerator ExecuteWinCondition()
        {
            yield return new WaitForSeconds(2);
            SceneManager.LoadScene("Completed");
        }
    }
}
