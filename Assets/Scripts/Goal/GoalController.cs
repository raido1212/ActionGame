using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

public class GoalController : MonoBehaviour
{

    private ReactiveProperty<bool> _goal = new ReactiveProperty<bool>();
    public IReadOnlyReactiveProperty<bool> Goal => _goal;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            _goal.Value = true;
        }
    }
}
