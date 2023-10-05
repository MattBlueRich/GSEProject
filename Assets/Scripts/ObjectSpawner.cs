using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> illusions;
    [SerializeField]
    private List<GameObject> fortunes;
    [SerializeField]
    private List<GameObject> spawnPoints;

    [SerializeField]
    private int timeBetweenSpawns;

    [SerializeField]
    private int fallingVelocity = 1;

    public List<GameObject> illusionsInGame;
    public List<GameObject> fortunesInGame;




    void Start()
    {
        StartCoroutine(Spawner());
    }

    void Update()
    {
        if(illusionsInGame != null)
        {
            foreach (GameObject illusion in illusionsInGame)
            {
                if (illusion.GetComponent<Rigidbody2D>() != null)
                {
                    Rigidbody2D rb2D = illusion.GetComponent<Rigidbody2D>();
                    rb2D.velocity = new Vector2(0, -fallingVelocity);
                }
            }
        }
        if (fortunesInGame != null)
        {
            foreach (GameObject fortune in fortunesInGame)
            {
                if (fortune.GetComponent<Rigidbody2D>() != null)
                {
                    Rigidbody2D rb2D = fortune.GetComponent<Rigidbody2D>();
                    rb2D.velocity = new Vector2(0, -fallingVelocity);
                }
            }
        }

    }


    void SpawnIllusion()
    {
        int illusionNumber = Random.Range(0, illusions.Count);
        GameObject illusionObject = illusions[illusionNumber];

       GameObject illusionInGame = Instantiate(illusionObject, RandomSpawnPoint().position, Quaternion.identity);

        illusionsInGame.Add(illusionInGame);
    }

    void SpawnFortune()
    {
        int fortuneNumber = Random.Range(0, fortunes.Count);
        GameObject fortuneObject = fortunes[fortuneNumber];

        GameObject fortuneInGame = Instantiate(fortuneObject, RandomSpawnPoint().position, Quaternion.identity);

        fortunesInGame.Add(fortuneInGame);

    }

    Transform RandomSpawnPoint()
    {
        int spawnPointNumber = Random.Range(0, spawnPoints.Count);
        GameObject spawnPointObj = spawnPoints[spawnPointNumber];

        return spawnPointObj.transform;
    }

    IEnumerator Spawner()
    {
        SpawnIllusion();
        yield return new WaitForSeconds(timeBetweenSpawns);
        SpawnIllusion();
        yield return new WaitForSeconds(timeBetweenSpawns);
        SpawnIllusion();
        yield return new WaitForSeconds(timeBetweenSpawns);
        SpawnIllusion();
        yield return new WaitForSeconds(timeBetweenSpawns);
        SpawnFortune();
        yield return new WaitForSeconds(timeBetweenSpawns);
        StartCoroutine(Spawner());

    }
}
