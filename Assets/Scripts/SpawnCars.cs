using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class SpawnCars : MonoBehaviour
{
    public Text scoreText;
    public float score = 0;
    public float bestScore;
    private static bool _game = false;
    
    
    
    public GameObject[] cars;
    private float[] positions = {
        -1.73f, -0.64f, 0.6f, 1.72f
    };
        void Start()
    {
        StartCoroutine(spawn());
        _game = true;
        bestScore = PlayerPrefs.GetFloat("bestScore");
    }

        private void Update()
        {
            scoreText.text = "" + score;
        }

        IEnumerator spawn()
    {
        int i, j, iteration=0;
        float speed = 3f;
        while (true)
        {
            i = Random.Range(0, positions.Length);
            j = Random.Range(0, positions.Length);
            if (j == i) j = (j + 1) % 4;
            Instantiate(cars[Random.Range(0,cars.Length)],
                new Vector3(positions[i],6.75f,0),
                Quaternion.Euler(new Vector3(90,180,0)));
            yield return new WaitForSeconds(0.5f);
            Instantiate(cars[Random.Range(0,cars.Length)],
                new Vector3(positions[j],6.75f,0),
                Quaternion.Euler(new Vector3(90,180,0)));
            yield return new WaitForSeconds(speed);
            iteration++;
            if(_game)
                score++;
            else
            {
                break;
            }
            if (iteration % 8 == 0 & speed > 1) speed = speed - 0.5f;
        }
    }

        public void GameFinish()
        {
            _game = false;
            PlayerPrefs.SetFloat("score",score);
            if(bestScore< score)
                    
                PlayerPrefs.SetFloat("bestScore", score);
            SceneManager.LoadScene(2);
            
        }   
    
}
