using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class WorkScheduler : MonoBehaviour
{
    [SerializeField] GameObject _configCanvas;
    [SerializeField] GameObject _sessionCanvas;
    [SerializeField] Image _background;
    [SerializeField] Color _sessionConfigCanvas;
    [SerializeField] Color _sessionSectionNotCompletedColor;
    [SerializeField] Color _sessionSectionCompletedColor;
    [SerializeField] TMP_InputField _hoursInput;
    [SerializeField] TMP_InputField _minutesInput;
    
    float _sessionTime;
    float _totalTime;
    float _totalRemainingTime;
    bool _activeSession;

    void Start()
    {
    }

    public void StartSession()
    {
        _configCanvas.SetActive(false);
        _sessionCanvas.SetActive(true);
        int hours = int.Parse(_hoursInput.text);
        int minutes = int.Parse(_minutesInput.text);
        _totalTime = hours*60 + minutes;
        StartSection();
        
    }

    public void StartSection()
    {
        _totalRemainingTime-=5;
        _sessionTime = 0f;
        _activeSession = true;
    }

    void Update()
    {
        if(_activeSession)
        {
            _sessionTime+=Time.deltaTime;
               
        }
    }
}
