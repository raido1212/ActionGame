using System.Collections;
using System.Collections.Generic;
using System;
using UniRx;
using Cysharp.Threading.Tasks;
using UniRx.Triggers;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoalPresenter : MonoBehaviour
{
     GoalController controller;

    private void Awake()
    {
        controller = GetComponent<GoalController>();
    }

    // Start is called before the first frame update
    void Start()
    {
        this.UpdateAsObservable()
            .Where(_ => controller.Goal.Value)
            .DistinctUntilChanged()
            .Subscribe(_ =>
            {
                view();
                EndInGame().Forget();
            }).AddTo(this);
    }

    private void view()
    {
        Debug.Log("ÉNÉäÉA");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    async UniTaskVoid EndInGame()
    {
        await UniTask.Delay(TimeSpan.FromSeconds(3));
        SceneManager.LoadScene("Title");
    }
    
}
