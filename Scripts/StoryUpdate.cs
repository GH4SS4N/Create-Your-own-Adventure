using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;  
using System.IO;  

public class StoryUpdate : MonoBehaviour
{
    static string textFile = @"Assets/scripts/Story Design.txt";

    static int lineLength = 100;
    static string wholeText = "";

    public static ArrayList update() {
        ArrayList result = new ArrayList();

        wholeText = File.ReadAllText(textFile);  

        while (wholeText.Length > 0) {
            
            int stateNum;
            int.TryParse(GetNextTag().Substring(6, 1), out stateNum);
            //Debug.Log(stateNum + " :" + wholeText + "::");

            State state = ScriptableObject.CreateInstance<State>();
            state.setParameters(GetNextText(), stateNum);

            while (wholeText.Length > 0 && wholeText.Substring(0, 2).Equals("[p")) {
                GetNextTag();
            };

            result.Insert(stateNum - 1, state);
        }

        return result;    
    }

    static string GetNextText() {
        GetNextTag();
        string result = ArabicSupport.ArabicFixer.Fix(ExtractString(0, wholeText.IndexOf('[')));
        int startIndex = 0;
        int nextBreakIndex = result.Length;
        if (result.LastIndexOf('\n') == -1) {
            
        }
        while(nextBreakIndex > lineLength || result.IndexOf
        return result;
    }

    static string GetNextTag() {
        string result = ExtractString(wholeText.IndexOf('['), wholeText.IndexOf(']') + 1);
        return result.Substring(1, result.Length - 2);
    }

    static string ExtractString(int start, int end) {
        string result = GetText(start, end);
        wholeText = wholeText.Substring(result.Length).Trim();

        return result;
    }
    
    static string GetText(int start, int end) {

        return wholeText.Substring(start, end);
    }
}
