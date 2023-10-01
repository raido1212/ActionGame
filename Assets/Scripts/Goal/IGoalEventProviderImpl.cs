using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using UniRx;
using UnityEngine;

namespace Goal
{
    public class IGoalEventProviderImpl : MonoBehaviour, IGoalEventProvider
    {

        #region
        public IReadOnlyReactiveProperty<bool> IsGoal => _isGoal;
        #endregion

        ReactiveProperty<bool> _isGoal = new ReactiveProperty<bool>();

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}