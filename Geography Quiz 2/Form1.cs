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
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCheckAnswer_Click(object sender, EventArgs e)
        {
            List<string> quizAnswers = new List<string>();
            
            string answer = txtAnswer1.Text;
            if (answer.Contains("Sacramento"))
            {
                MessageBox.Show("Correct!", "Result");
            }
            else
            {
                MessageBox.Show("Incorrect, the answer is Sarcramento", "Result");
            }

            string answer2 = txtAnswer2.Text;
            if (answer2.Contains("Everest"))
            {
                MessageBox.Show("Correct!", "Result");
            }
            else
            {
                MessageBox.Show("Incorrect, the answer is Everest", "Result");
            }

            string answer3 = txtAnswer3.Text;
            if (answer3.Contains("Chile")) 
            {
                MessageBox.Show("Correct!", "Result");
            }
            else 
            {
                MessageBox.Show("Incorrect, the answer is Chile", "Result");
            }
        }
    }
 }
