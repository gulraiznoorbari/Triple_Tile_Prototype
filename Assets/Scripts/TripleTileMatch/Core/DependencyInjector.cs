using TripleTileMatch.Controllers;
using TripleTileMatch.Views;
using UnityEngine;

namespace TripleTileMatch.Core
{
    public class DependencyInjector : MonoBehaviour
    {
        [Header("UI Refs")]
        [SerializeField] private UIController _uiController;
        [SerializeField] private UIView _uiView;
        [Header("Audio Refs")]
        [SerializeField] private AudioController _audioController;
        [SerializeField] private AudioView _audioView;
        [Header("Level Controller Refs")] 
        [SerializeField] private LevelController _levelController;

        private void Awake()
        {
            InjectDependencies();
        }

        private void InjectDependencies()
        {
            _uiController.UIViewHandler = _uiView;
            _uiView.UIControllerHandler = _uiController;
            
            _audioController.AudioViewHandler = _audioView;
            _audioView.AudioControllerHandler = _audioController;

            _uiController.LevelControllerHandler = _levelController;

            _uiController.AudioControllerHandler = _audioController;
        }
    }
}