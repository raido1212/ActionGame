using System;
using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Menu.Cell
{
    public enum MenuCellType
    {
        None,
        RemoveTop,
        Restart
    }

    public class MenuCell : MonoBehaviour
    {
        [SerializeField] MenuCellType _Type;

        public Subject<MenuCellType> _Cell = new Subject<MenuCellType>();
        public IObserver<MenuCellType> CellType => _Cell;

        private Button _Button;

        private void Awake()
        {
            TryGetComponent(out _Button);

            _Button.OnClickAsObservable()
                .Subscribe(_ => SendCelllType())
                .AddTo(this);
        }


        private void SendCelllType()
        {
            Debug.Log("‚¨‚³‚ê‚½:" + _Type.ToString());
            SceneManager.LoadScene("Title");
            //_Cell.OnNext(this._Type);
        }



    }
}