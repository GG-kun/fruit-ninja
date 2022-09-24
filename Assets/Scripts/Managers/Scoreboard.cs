using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Scoreboard
{
    // Number of maximum elements in scoreboard
    private static int count = 10;
    // Scores sorted in descending order
    private static List<int> scoreboard = new List<int>{};

    public static void AddScore(Score score) {
        if(Load()){
            Debug.Log("Load");
        }
        scoreboard.Add(score.GetScore());
        scoreboard.Sort(new SortIntDescending());
        for(int index = count; index < scoreboard.Count; index++){
            scoreboard.RemoveAt(index);
        }
    }

    public static List<int> GetScoreboard() {
        if(Load()){
            Debug.Log("Load");
        }
        return scoreboard;
    }

    public static bool Save() {
        return FileManager.WriteToFile("scoreboard.dat", string.Join(" ", scoreboard));
    }

    public static bool Load() {
        string scoreboardString;
        if(FileManager.LoadFromFile("scoreboard.dat", out scoreboardString)){
            scoreboard = new List<int>();
            foreach(string score in scoreboardString.Split(" ")) {
                scoreboard.Add(Int16.Parse(score));
            }
            return true;
        }
        return false;
    }
}
