using System;
namespace App2 {
     class Program {
         static void Main(string[] args) {
            string str, pig_word, cleaned_pig_word, english_word, cleaned_english_word;
            string pig_latin = "";
            string english_sentence = "";
            char first_letter, last_letter, capitalized_letter, small_letter;

            Console.Write("Enter a sentence: ");
            str = Console.ReadLine();

            string[] sentence_array = str.Split(" ");


             for (int i = 0; i < sentence_array.Length; i++) { 
                first_letter = char.ToLower(sentence_array[i][0]); 
                pig_word = sentence_array[i]+first_letter+"ay";
                cleaned_pig_word = pig_word.Remove(0,1);
                if(i == 0){
                    capitalized_letter= char.ToUpper(cleaned_pig_word[0]);
                    pig_latin= pig_latin + capitalized_letter+cleaned_pig_word.Remove(0,1);
                } else {
                    pig_latin= pig_latin + " " + cleaned_pig_word;
                }
            }   

            Console.WriteLine("Your sentence is \'" + pig_latin + "\' in pig latin." );

            string[] pig_array = pig_latin.ToString().Split(" ");
            
            for (int i = 0; i < pig_array.Length; i++) { 
                english_word = pig_array[i].Remove(pig_array[i].Length - 2);
                last_letter = english_word[english_word.Length - 1];
                cleaned_english_word = last_letter + english_word.Remove(english_word.Length-1);
                if (i == 0){
                    capitalized_letter= char.ToUpper(cleaned_english_word[0]);
                    small_letter= char.ToLower(cleaned_english_word[1]);
                    english_sentence= english_sentence + capitalized_letter + small_letter + cleaned_english_word.Remove(0,2);
                }  else {
                    english_sentence = english_sentence + " " + cleaned_english_word;
                }  
            }      
            Console.Write("Your original sentence is: " + english_sentence);
        }
    }
}
