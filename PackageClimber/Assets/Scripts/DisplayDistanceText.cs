using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DisplayDistanceText : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _distanceText; // Reference to the UI text for the current distance
    [SerializeField] private TextMeshProUGUI _bestScoreText; // Reference to the UI text for the best score
    [SerializeField] private Transform _playerTrans; // Reference to the player's transform

    private Vector2 _startPosition; // The starting position of the player
    private float _bestScore; // Variable to store the best score (maximum distance)

    private void Start()
    {
        _startPosition = _playerTrans.position;

        // Load the best score from PlayerPrefs (if any)
        _bestScore = PlayerPrefs.GetFloat("BestScore", 0f); // Default to 0 if no score is saved

        // Update the best score text at the start
        UpdateBestScoreText();
    }

    private void Update()
    {
        // Calculate the distance in the x direction
        Vector2 distance = (Vector2)_playerTrans.position - _startPosition;

        // Keep the distance on the x-axis only
        distance.y = 0f;

        // If the player moves backwards, don't let the distance go negative
        if (distance.x < 0)
        {
            distance.x = 0;
        }

        // Update the current distance text
        _distanceText.text = distance.x.ToString("F0") + " m";

        // Check if the current distance is greater than the best score
        if (distance.x > _bestScore)
        {
            _bestScore = distance.x; // Update the best score

            // Save the new best score to PlayerPrefs
            PlayerPrefs.SetFloat("BestScore", _bestScore);

            // Update the best score text
            UpdateBestScoreText();
        }
    }

    // Update the best score text UI
    private void UpdateBestScoreText()
    {
        _bestScoreText.text = "Best: " + _bestScore.ToString("F0") + " m";
    }
}
