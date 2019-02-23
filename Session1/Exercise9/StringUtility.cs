using System;

class StringUtility{

    public static string SummarizeText(string text){
        string summarizedText="";
        string[] splittedText=text.Split(' ');
        int sum=0;
        for(int i=0;i<splittedText.Length;i++){
            if(sum+splittedText[i].Length<=20 && i!=0){
                summarizedText+=" "+splittedText[i];
                sum+=splittedText[i].Length;
            }
            else if(sum+splittedText[i].Length<=20){
                summarizedText+=splittedText[i];
                sum+=splittedText[i].Length;
            }
            else{
                summarizedText+="...";
                return summarizedText;
            }
        }
        return summarizedText;
    }
}