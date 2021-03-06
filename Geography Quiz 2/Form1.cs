﻿/* Geography Quiz 2 (Design TEAM, code individual)

Start a new app.

    This app will ask at least three geography questions, one question at a time.
    The app will keep track of how many questions the user answers correctly. 
    Your app will need to track how long the user took to complete the quiz.
    At the end of the quiz, the user should be shown their score, 
    and the correct answers to any questions they answered incorrectly,
    and the time taken to complete the quiz in minutes. 

Here's some example questions, or you may use your own:

    Q: What is the state capital of California? A: Sacramento
    Q: What is the tallest mountain in the world? A: Everest
    Q: Which country has the furthest south extent?: A: Chile

Design your app in class. Draw sketches of your Form and describe the way your app will work.
How will your app check for correct answers? How will it store incorrect answers, 
and the user's score? How will it figure out how long it takes the user to complete the quiz? 
What else do you need to think about?

Check in with me in class before you start coding. 
You must get your design approved in class before you start coding. 

Finish the code and testing of your app individually.

Make sure you add comments describing your method and reasoning for how you decide if an answer is correct. 
How will you balance accepting correct answers, with the chance of permitting wrong answers?
 
Update:

 Cheat function for Geography Quiz 2 App.  Add a Cheat button to the app you built for Week 7. 
 This button will be shown when the app is asking the user a question. 
 When the Cheat button is clicked, the app will show the answer to the current question in a new Cheat form.  
 The Cheat form should have a "Close" button, and an "I'm Lazy" button.  
 When the close button is clicked, the Cheat form will close.  
 When the I'm Lazy button is clicked, the correct answer is filled n the Quiz form. 
 
 
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

        //Create a SortList with data type as strings for key-value pair.  
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
            ShowMyNextQuestion();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCheckAnswer_Click(object sender, EventArgs e)
        {
            CheckKey();//call key to check for correct answer
            ShowMyNextQuestion();//call method to show next question
        }  
            
        private void ShowMyNextQuestion() 
        {
            queryNumber++;// declaring variable to move to next question

            txtUserAnswer.Text = ""; // clear previous answer

            if(queryNumber< queryList.Count)//checking each question in the SortedList 
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

        //Checking 
        private void CheckKey()
        {
            try
            {
                if (queryNumber < queryList.Count)//
                {
                    KeyValuePair<string, string> inquiry = queryList.ElementAt(queryNumber);
                    string correctAnswer = inquiry.Value;

                    if (txtQuestions.Text.Contains(correctAnswer))
                    {
                        Score++;
                    }
                    lblScore.Text = $"Score: {Score}";

                    if (txtUserAnswer.Text.Contains(correctAnswer))// checking user input for right answer
                    {
                        Score++;// tally user's corrected response
                    }
                    lblScore.Text = $"Score: {Score}";//label score displays scores
                }
            }
            catch (FormatException fe)
            {
                MessageBox.Show("Please enter valid letters only for the answer field.", "Entry Error");
                txtUserAnswer.Focus();
                throw fe;
            }

        }

        private void btnCheat_Click(object sender, EventArgs e)
        {
            KeyValuePair<string, string> inquiry = queryList.ElementAt(queryNumber);
            string correctAnswer = inquiry.Value;

            frmCheat fmCheat = new frmCheat(); // generate new frmCheat form
            fmCheat.Tag = correctAnswer; // create the tag to present string in lblCheat
            DialogResult CheatResults = fmCheat.ShowDialog();//print form

            if(CheatResults == DialogResult.OK) 
            {
                if (fmCheat.Tag is string lazy) 
                {
                    lblCheat.Text = lazy;
                    txtUserAnswer.Text = lazy;// text box auto fill corrected answer when user selected cheat button is pressed. 
                }
            }
        }
    }
 }
