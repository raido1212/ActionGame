using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

namespace Goal
{
    public interface IGoalEventProvider
    {
        IReadOnlyReactiveProperty<bool> IsGoal { get; }
    }
}