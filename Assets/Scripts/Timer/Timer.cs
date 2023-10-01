using Cysharp.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using TMPro;
using UniRx;
using UniRx.Triggers;
using UnityEngine;


namespace Timer
{
    public class Timer : MonoBehaviour
    {
        [SerializeField] TextMeshProUGUI _timerText;

        [SerializeField] GoalController _goalController;

        float _baseTime;

        CancellationTokenSource _cancellationTokenSource;

        void Start()
        {
            _timerText.text = "00:00";

            //_cancellationTokenSource = new CancellationTokenSource();

 /*           this.UpdateAsObservable()
                .First(_ => this._goalController.Goal.Value)
                .Skip(1)
                .Subscribe(_ => this._cancellationTokenSource.Cancel())
                .AddTo(this);*/

            //_ = UpdateTimer(_cancellationTokenSource.Token);
        }

        // Update is called once per frame
        void Update()
        {

        }

        private void FixedUpdate()
        {
            if (_goalController.Goal.Value)
            {
                return;
            }
            UpdateTimer().Forget();
        }

        private async UniTaskVoid UpdateTimer()
        {
            _baseTime += Time.deltaTime;
            var iTime = (int)(_baseTime * 100);
            _timerText.text = $"{(iTime / 100).ToString("d2")}:{(iTime % 100).ToString("d2")}";
        }
    }
}