using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Menu.Cell;
using UniRx;
using Unity.VisualScripting;
using UnityEngine.UI;

namespace Menu
{
    public class MenuButton : MonoBehaviour
    {


        [SerializeField] GameObject _parentButtons;
        [SerializeField] Image _image;

        private Button _button;

        private bool isOpenButtons;

        private void Awake()
        {
            TryGetComponent(out _button);
            
            _image.gameObject.SetActive(false);

            this._button.OnClickAsObservable()
                .Subscribe(_ => ShowMenuButton(isOpenButtons ^= true))
                .AddTo(this);
        }

        // Start is called before the first frame update
        void Start()
        {

        }

        void ShowMenuButton(bool isShow)
        {
            _image.gameObject.SetActive(isShow);
            _parentButtons.SetActive(isShow);
        }
    }
}
