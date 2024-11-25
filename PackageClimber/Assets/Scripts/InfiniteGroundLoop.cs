using UnityEngine;

public class InfiniteGroundLoop : MonoBehaviour
{
    public Transform player; // The player's transform
    public Transform leftPlatform; // The left platform
    public Transform rightPlatform; // The right platform
    public float platformWidth; // The width of the platforms (assuming both platforms have the same width)
    public GameObject fuelCanisterPrefab; // The fuel canister prefab to spawn
    public float fuelCanisterHeight = 1.0f; // Height above the ground for spawning the fuel canister
    public float minSpawnTime = 2f; // Minimum time between spawns
    public float maxSpawnTime = 5f; // Maximum time between spawns

    private float playerEndPosition; // The X position where the player reaches the end of the platform
    private float nextSpawnTime; // Time to spawn the next fuel canister

    void Start()
    {
        // Initializing the end position for the player (when the player reaches the end of the right platform)
        playerEndPosition = rightPlatform.position.x + platformWidth;
        // Set the initial time for the next spawn
        SetNextSpawnTime();
    }

    void Update()
    {
        // Check if the player has passed the right platform's end position
        if (player.position.x >= playerEndPosition)
        {
            // Move the left platform to the front (right of the right platform)
            MoveLeftPlatformToFront();
            // Update the player end position
            UpdatePlayerEndPosition();
            // Spawn the fuel canister if it's time
            SpawnFuelCanister();
        }
    }

    // Moves the left platform to the front (right of the right platform)
    void MoveLeftPlatformToFront()
    {
        // Move the left platform to the right of the right platform without moving the current platform
        leftPlatform.position = new Vector3(rightPlatform.position.x + platformWidth, leftPlatform.position.y, leftPlatform.position.z);

        // Swap the platforms: The previously right platform becomes left, and the previously left platform becomes right.
        SwapPlatforms();
    }

    // Updates the player's end position after the platform swap
    void UpdatePlayerEndPosition()
    {
        playerEndPosition = rightPlatform.position.x + platformWidth;
    }

    // Swap the platforms: left becomes right, and right becomes left
    void SwapPlatforms()
    {
        // Swap the references of the platforms for the next check
        Transform temp = leftPlatform;
        leftPlatform = rightPlatform;
        rightPlatform = temp;
    }

    // Spawns the fuel canister at a random position above the ground
    void SpawnFuelCanister()
    {
        if (Time.time >= nextSpawnTime)
        {
            // Spawn the fuel canister above the ground, slightly offset on the y-axis
            Vector3 spawnPosition = new Vector3(rightPlatform.position.x + platformWidth / 2, rightPlatform.position.y + fuelCanisterHeight, rightPlatform.position.z);
            Instantiate(fuelCanisterPrefab, spawnPosition, Quaternion.identity);
            // Set the next spawn time
            SetNextSpawnTime();
        }
    }

    // Set the next spawn time randomly between the min and max range
    void SetNextSpawnTime()
    {
        nextSpawnTime = Time.time + Random.Range(minSpawnTime, maxSpawnTime);
    }
}
