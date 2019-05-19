using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
    
    [SerializeField] Text storyText;

    ArrayList states;
    int stateNum = 1;

    //State state;

    // Start is called before the first frame update
    void Start()
    {
        states = StoryUpdate.update();
        
        UpdateStoryText();
    }

    void UpdateStoryText() {
        storyText.text = ((State) states[stateNum - 1]).GetStateStory();
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}

