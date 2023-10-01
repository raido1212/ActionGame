using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;
using UnityEngine.InputSystem;

public static class InputSystemExtension
{
    public static ReadOnlyReactiveProperty<bool> GetButtonProperty(this InputAction inputAction)
    {
        return Observable.FromEvent<InputAction.CallbackContext>(
                h => inputAction.performed += h,
                h => inputAction.performed -= h)
            .Select(x => x.ReadValueAsButton())
            .ToReadOnlyReactiveProperty(false);
    }

    //Axis���͂���0�����������Ȃ�����GetDeltaAxisProperty�݂̂̎g�p�ł��悳�����ł�
    public static ReadOnlyReactiveProperty<float> GetAxisProperty(this InputAction inputAction)
    {
        return Observable.FromEvent<InputAction.CallbackContext>(
                h => inputAction.performed += h,
                h => inputAction.performed -= h)
            .Select(x => x.ReadValue<float>())
            .ToReadOnlyReactiveProperty(0);
    }

    //Delta���͂�Update��Ȃ̂�Update��ɕϊ�(��Ƀ}�E�X�Ŏg�p)
    public static ReadOnlyReactiveProperty<float> GetDeltaAxisProperty(this InputAction inputAction)
    {
        return Observable.EveryUpdate().Select(_ => inputAction.ReadValue<float>()).ToReadOnlyReactiveProperty(0);
    }

}
