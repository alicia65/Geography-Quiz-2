/* Geography Quiz 2 (Design TEAM, code individual)

Start a new app.

    This app will ask at least three geography questions, one question at a time.
    The app will keep track of how many questions the user answers correctly. 
    Your app will need to track how long the user took to complete the quiz.
    At the end of the quiz, the user should be shown their score, and the correct answers to any questions they answered incorrectly, and the time taken to complete the quiz in minutes. 

Here's some example questions, or you may use your own:

    Q: What is the state capital of California? A: Sacramento
    Q: What is the tallest mountain in the world? A: Everest
    Q: Which country has the furthest south extent?: A: Chile

Design your app in class. Draw sketches of your Form and describe the way your app will work. How will your app check for correct answers? How will it store incorrect answers, and the user's score? How will it figure out how long it takes the user to complete the quiz? What else do you need to think about?

Check in with me in class before you start coding.  You must get your design approved in class before you start coding. 

Finish the code and testing of your app individually.

Make sure you add comments describing your method and reasoning for how you decide if an answer is correct. How will you balance accepting correct answers, with the chance of permitting wrong answers?
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geography_Quiz_2
{
    public partial class Form1 : Form
    {
        //Generate global variables for the quiz to use in the app

        //Create a SortList with data types as strings for key-value pair.  
        //Keys are questions.  Values are answers.
        //Queries is the name of the SortList and contains three elements
        private SortedList<string, string> queryList = new SortedList<string, string>()
        { {"What is the state capital of California?","Sacramento" },
            {"What is the tallest mountain in the world?", "Everest"},
            {"Which country has the furthest south extent?", "Chile"} };
       
        private int queryNumber = -1;
        private int Score = 0; 
        
        public Form1()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCheckAnswer_Click(object sender, EventArgs e)
        {
            ShowMyNextQuestion();
            CheckKey();

        }

        private void ShowMyNextQuestion() 
        {
            queryNumber++;

            if(queryNumber< queryList.Count) 
            {
                KeyValuePair<string, string> query = queryList.ElementAt(queryNumber);
                string queryTxt = query.Key;
                txtQuestions.Text = queryTxt;
            }
            else 
            {
                btnCheckAnswer.Enabled = false;
                btnCheckAnswer.Text = "Quiz over!";
                MessageBox.Show($"Your score is {Score}", "Quiz Over!");
            }
            
        }

        private void CheckKey() 
        {
            if(queryNumber < queryList.Count) 
            {
                KeyValuePair<string, string> inquiry = queryList.ElementAt(queryNumber);
                string correctAnswer = inquiry.Value;

                if(correctAnswer == txtQuestions.ContainsKey(string)) 
                {
                    Score++;
                }
                lblScore.Text = $"Score: {Score}";

            }
        }
        
    }
 }
