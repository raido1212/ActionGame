using System.Collections;
using System.Collections.Generic;
using UniRx;
using UniRx.Triggers;
using UnityEngine;

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
}
