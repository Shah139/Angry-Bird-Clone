using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{
    [SerializeField] string _nextLevelName;
    monster[] _monsters;
    
   
    void OnEnable()
    {
        _monsters = FindObjectsOfType<monster>();
    }
    // Update is called once per frame
    void Update()
    {
        if (MonstersAreAllDead())
            GoToNextLevel();
    }

    void GoToNextLevel()
    {

        Debug.Log("Go to level" + _nextLevelName);
        SceneManager.LoadScene(_nextLevelName);
    } 

    bool MonstersAreAllDead()
    {
        foreach (var Monster in _monsters)
        {
            if (Monster.gameObject.activeSelf)
                return false;
        }

        return true;  
    }
}
