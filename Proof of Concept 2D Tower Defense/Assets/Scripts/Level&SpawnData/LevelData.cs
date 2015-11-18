using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class LevelData : MonoBehaviour
{
	public int levelIndex;
	public int waveIndex;


	/*
	class levelInfo{
		public int levelAmount;
		public int waveAmount;
		//Array voor enemytypes in dit level
	}*/
	class WaveSetting
	{
		public int enemyCount;
		public int spawnIntervalMin;
		public int spawnIntervalMax;
		public int waveInterval;
	}

//	List<LevelInfo> levelContent = new List<LevelInfo> ();
	List<WaveSetting>  waveSettings = new List<WaveSetting>();

	void Start(){
		//addLevel (3,5);

		// Wave - (enemyAmount, spawnIntervalMin, spawnIntervalMax, waveInterval)
		addWave (10, 2, 2, 5);
		addWave (12, 3, 3, 5);
		addWave (17, 3, 4, 5);
		addWave (23, 4, 4, 5);

	}

	/*
	private void addLevel (int levelAmount, int waveAmount){
		LevelInfo Linfo = new LevelInfo ();
		Linfo.LevelAmount = LevelAmount;
		Linfo.waveAmount = new waveAmount;
		levelContent.Add(Linfo);

	}*/

	private void addWave(int enemyCount, int spawnIntervalMin, int spawnIntervalMax, int waveInterval){
		WaveSetting Winfo = new WaveSetting ();
		Winfo.enemyCount = enemyCount;
		Winfo.spawnIntervalMin = spawnIntervalMin;
		Winfo.spawnIntervalMax = spawnIntervalMax;
		waveSettings.Add (Winfo);
	}












	/*
    private int regulateTimer = 5;
    private int newWaveWait = 5;

    private int currentWave = 0;
    private int enemyWaveAmount = 0;
    private int enemiesAlive = 0;
    private bool waveOnGoing = false;


    [SerializeField]
    public float SpawnRateMin = 2; //Minimaal aantal seconden die de spawners moeten wachten voordat er een nieuw object wordt gespawnd
    [SerializeField]
    public float SpawnRateMax = 2; //Maximaal aantal seconden die de spawners moeten wachten voordat er een nieuw object wordt gespawnd



    // Use this for initialization
    void Awake()
    {
        StartNewWave();
        currentWave = 1;

    }

    // Update is called once per frame
    void Update()
    {
        if (!waveOnGoing)
        { 
            regulateTimer -= Time.deltaTime;
                if (regulateTimer < 0)
                {
                    if (enemiesAlive <= 0)
                    {
                        Debug.Log("Next Wave will begin in 5 seconds");
                        waveOnGoing = false;
                        regulateTimer = 5;

                        if (currentWave == 1)
                        {
                            currentWave++;
                            StartNewWave(20,2,2);
                        }
                        else if (currentWave == 2)
                        {
                            currentWave++;
                            StartNewWave(30,2,2);
                        }
                        else if (currentWave == 3)
                        {
                            currentWave++;
                            StartNewWave(40,2,2);
                        }
                        else if (currentWave == 4)
                        {
                           currentWave++;
                            StartNewWave(50,2,2);
                        }
                      }
                }
        }
    }

    private void StartNewWave(int nrOfEnemies, float spawnTimeMin, float spawnTimeMax)
    {
        if(!waveOnGoing)
        newWaveWait -= Time.deltaTime;
             if (newWaveWait <= 0)
             {
                enemyWaveAmount = nrOfEnemies;
                waveOnGoing = true;
             }
            	
    }*/
}
