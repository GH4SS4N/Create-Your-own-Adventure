using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "State")]

public class State : ScriptableObject
{
    [TextArea(5,10)] [SerializeField] string storyText;
    //[SerializeField] string[] options;

    int id;

    public void setParameters(string storyText, int id) {
        this.storyText = storyText;
        this.id = id;
    }

    public string GetStateStory()
    {
        return this.storyText;
    }

    public int getId() {
        return this.id;
    }
}
